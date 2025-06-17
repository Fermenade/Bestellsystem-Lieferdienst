using Client_Server_Code_Library;
using MySql.Data.MySqlClient;
using System.Reflection;


namespace Bestellsystem_Lieferdienst_Server.DAL;

public class DatabaseHelper(string connectionString)
{

    private long InsertItemIntoTableSession(SqlCommand query, MySqlConnection _connection)
    {
        using (var command = new MySqlCommand(query.SqlStatement, _connection))
        {
            foreach (var VARIABLE in query.Parameters)
            {
                command.Parameters.AddWithValue(VARIABLE.Item1, VARIABLE.Item2);
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex) // Catching specific exception related to MySQL
            {
                throw new Exception("Failed to insert item: " + query.SqlStatement);
            }

            return command.LastInsertedId;
        }
    }
    public long InsertItemIntoTable(SqlCommand query)
    {
        using (MySqlConnection _connection = new(connectionString))
        {
            _connection.Open();
            return InsertItemIntoTableSession(query, _connection);
        }
    }

    // Generated
    /// <summary>
    /// Inserts a new item into the specified database table and returns specified columns from the inserted item.
    /// </summary>
    /// <remarks> It is best practice to define a primary key with AUTO_INCREMENT for tables that require unique identifiers.</remarks>
    /// <param name="query">The SQL command containing the insert statement and parameters.</param>
    /// <param name="returnColumns">An array of column names to return from the inserted item.</param>
    /// <returns>An object containing the specified columns from the newly inserted item.</returns>
    /// <exception cref="ArgumentNullException">Thrown when the query or returnColumns are null.</exception>
    /// <exception cref="SqlException">Thrown when there is an error executing the SQL command.</exception> Generated end
    public object[]? InsertAndReturnSpecifiedColumns(SqlCommand query, string table, string[]? returnColumns = null)
    {
        long? lastId;
        using (MySqlConnection _connection = new(connectionString))
        {
            lastId = InsertItemIntoTableSession(query, _connection);
        }
        //this is a small buggy optimisation
        if (returnColumns == null)
        {
            throw new Exception("Return columns where null");
        }

        SqlCommand sql = new SqlCommand().SelectColumnsById(table, returnColumns, lastId.Value);

        return GetDataFromDatabase(sql)?[0];
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

        ConstructorInfo? matchedConstructor = null;

        IEnumerable<ConstructorInfo> constructors = typeof(T).GetConstructors().Where(p => Attribute.IsDefined(p, typeof(DatabaseConstructorAttribute)));
        ConstructorInfo[] constructorInfos = constructors as ConstructorInfo[] ?? constructors.ToArray();

        if (constructorInfos.Count() == 1)
        {
            matchedConstructor = constructorInfos.First();
        }
        else
        {
            throw new InvalidOperationException($"Expected exactly one constructor not marked with DatabaseConstructorAttribute. Found {constructorInfos.Count()}.");
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