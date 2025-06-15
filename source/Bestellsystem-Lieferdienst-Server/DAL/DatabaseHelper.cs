using MySql.Data.MySqlClient;
using System.Reflection;
using System.Runtime.InteropServices;
using Client_Server_Code_Library;


namespace Bestellsystem_Lieferdienst_Server.DAL;

public class DatabaseHelper(string connectionString)
{
    private MySqlConnection _connection = new(connectionString); //if this fails database couldn't be reached.

    public int InsertItemIntoTable(SqlCommand query)
    {
        using (MySqlConnection _connection = new(connectionString))
        {
            _connection.Open();

            using (var command = new MySqlCommand(query.SqlStatement, _connection))
            {
                foreach (var VARIABLE in query.Parameters)
                {
                    command.Parameters.AddWithValue(VARIABLE.Item1, VARIABLE.Item2);
                }

                try
                {
                    return command.ExecuteNonQuery();
                }
                catch (MySqlException ex) // Catching specific exception related to MySQL
                {
                    throw new Exception("Failed to insert item: " + query.SqlStatement);
                }
            }
        }
    }
    /// <summary>
    /// Execute a non Value returning sql command.
    /// eg. INSERT, UPDATE
    /// </summary>
    /// <param name="query">The sql query</param>
    /// <returns>The amount of rows affected.</returns>
    public int ExecuteNonQuery(SqlCommand query)
    {
        using (MySqlCommand command = new MySqlCommand(query.SqlStatement, _connection))
        {
            foreach (var VARIABLE in query.Parameters)
            {
                command.Parameters.AddWithValue(VARIABLE.Item1, VARIABLE.Item2);
            }

            return command.ExecuteNonQuery(); //TODO: Make it run async
        }
    }

    /// <summary>
    /// Get a single row in a table selected from the ID.
    /// </summary>
    /// <param name="id">ID of the row</param>
    /// <param name="tableName">Name of the table</param>
    /// <typeparam name="T">T must be type class. The type the data should be converted into.</typeparam>
    /// <remarks>This method truncates any other returned data except the first row</remarks>
    /// <returns>The first selected row</returns>
    public T? GetDataFromID<T>(SqlCommand query) where T : class
    {
        var i = GetDataFromDatabase<T>(query);
        if (i.Length == 0)
            return null;

        return i[0];
    }
    /// <summary>
    /// Takes a sql query, executes it and returns the output as an array of provided type.
    /// </summary>
    /// <param name="query">The sql query</param>
    /// <typeparam name="T">T must be of type class. The type the data should be converted into.</typeparam>
    /// <exception>If a types constructor doesn't satisfy all values from the database. Exception will be thrown.</exception>
    /// <returns>Returns all rows selected from the database converted into the provided type</returns>
    public T[] GetDataFromDatabase<T>(SqlCommand query) where T : class
    {
        //Generated
        List<T> results = [];
        var o = GetDataFromDatabase(query);
        if (o.Length == 0) return [];

        ConstructorInfo? matchedConstructor = typeof(T).GetConstructors().First(p => !Attribute.IsDefined(p, typeof(DatabaseConstructorAttribute)));


        if (matchedConstructor == null)
        {
            throw new Exception("Did not find matching constructor.");
        }

        foreach (object[] VARIABLE in o)
        {
            // Create an instance of T using the constructor and the arguments
            var instance = (T)matchedConstructor.Invoke(VARIABLE);
            results.Add(instance);
        }

        return results.ToArray();
    }
    //generated
    private bool IsNullable(Type type)
    {
        if (Nullable.GetUnderlyingType(type) != null)
        {
            return true;
        }
        return !type.IsValueType;
    }
    /// <summary>
    /// Takes a sql query, executes it and returns the output as two-dimensional object array.
    /// </summary>
    /// <param name="query">The sql query</param>
    /// <exception cref="Exception">Error reading data from database</exception>
    /// <exception cref="Exception">Could not find any matching data.</exception>
    /// <returns>A nested array of all entries returned by the query.</returns>
    public object[][]? GetDataFromDatabase(SqlCommand query)
    {
        List<object[]> data = new List<object[]>();
        using (MySqlConnection _connection = new(connectionString))
        {
            _connection.Open();

            using (MySqlCommand command = new MySqlCommand(query.SqlStatement, _connection))
            {

                foreach (var VARIABLE in query.Parameters ?? [])
                {
                    command.Parameters.AddWithValue(VARIABLE.Item1, VARIABLE.Item2);
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader == null) throw new Exception("Error reading data from database");
                    while (reader.Read())
                    {
                        List<object> temp = new List<object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            temp.Add(reader.GetValue(i));
                        }

                        data.Add(temp.ToArray());
                    }
                }
            }
            return data.ToArray();
        }
    }
}