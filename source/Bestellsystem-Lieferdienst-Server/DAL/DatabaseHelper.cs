using MySql.Data.MySqlClient;
using System.Data;
using System.Reflection;

namespace Bestellsystem_Lieferdienst_Server.DAL;

public class DatabaseHelper(string connectionString)
{
    private MySqlConnection _connection = new(connectionString); //if this fails database couldn't be reached.

    public void InsertItemIntoTable<T>(string tableName, T item) where T : class
    {
        //TODO: ChatGPT hat da quatsch gemacht, verbessern.
        //ich weiß nicht, ob die var namen der types wirklich alle matchen.
        // außerdem wenn die item so geholt werden, warum hab ich mir überhaupt die arbeit mit den
        // toString gemacht???


        //Generated
        if (_connection == null || String.IsNullOrEmpty(tableName))
            throw new ArgumentException(); // Validate input parameters

        var properties = typeof(T).GetProperties();
        string columns = String.Join(", ", properties.Select(p => p.Name));

        var cmd = $"INSERT INTO '{tableName}' ({columns}) VALUES ({item.ToString()});";

        using (var command = new MySqlCommand(cmd, _connection))
        {
            for (int i = 0; i < properties.Length; ++i)
            {
                var propertyValue = properties[i].GetValue(item);

                // Assuming all property values are of the type string, you might need to adjust this part according to your needs
                command.Parameters.AddWithValue("@" + i,
                    (propertyValue == null)
                        ? DBNull.Value
                        : Convert.ChangeType(propertyValue, propertyValue.GetType()));
            }

            try
            {
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex) // Catching specific exception related to MySQL
            {

                throw new Exception("Failed to insert item: " + item);

            }
        }
    }
    /// <summary>
    /// Execute a non Value returning sql command.
    /// eg. INSERT, UPDATE
    /// </summary>
    /// <param name="query">The sql query</param>
    /// <returns>The amount of rows affected.</returns>
    public int ExecuteNonQuery(string query)
    {
        _connection.Open();
        using (MySqlCommand command = new MySqlCommand(query, _connection))
        {
            _connection.Close();
            return command.ExecuteNonQuery(); //TODO: Make it run async
        }
    }

    /// <summary>
    /// Get a single row in a table selected from the ID.
    /// </summary>
    /// <param name="id">ID of the row</param>
    /// <param name="tableName">Name of the table</param>
    /// <typeparam name="T">T must be type class. The type the data should be converted into.</typeparam>
    /// <remarks>The ID column is default {tableName}ID</remarks>
    /// <returns>The selected row of the database converted into the matching type</returns>
    public T GetDataFromID<T>(int id, string tableName) where T : class
    {
        string sql = $"""SELECT * FROM {tableName} WHERE {tableName}ID = {id}""";
        var i = GetDataFromDatabase<T>(sql);
        return i[0];
    }
    /// <summary>
    /// Takes a sql query, executes it and returns the output as an array of provided type.
    /// </summary>
    /// <param name="query">The sql query</param>
    /// <typeparam name="T">T must be of type class. The type the data should be converted into.</typeparam>
    /// <exception>If a types constructor doesn't satisfy all values from the database. Exception will be thrown.</exception>
    /// <returns>Returns all rows selected from the database converted into the provided type</returns>
    public T[] GetDataFromDatabase<T>(string query) where T : class
    {
        //Generated
        List<T> results = [];
        var o = GetDataFromDatabase(query);
        ConstructorInfo? matchedConstructor = null;

        //Check if the class has a matching constructor
        foreach (var VARIABLE in typeof(T).GetConstructors())
        {
            var x = VARIABLE.GetParameters();
            if (o[0].Length == x.Length)
            {
                bool validConsturctorExists = true;
                for (int i = 0; i < x.Length; ++i)
                {
                    if (o[0][i].GetType() != x[i].ParameterType)
                    {
                        validConsturctorExists = false;
                        break;
                    }
                }

                if (validConsturctorExists)
                {
                    matchedConstructor = VARIABLE;
                    break;
                }
            }
        }
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
    /// <summary>
    /// Takes a sql query, executes it and returns the output as two-dimensional object array.
    /// </summary>
    /// <param name="query">The sql query</param>
    /// <exception cref="Exception">Error reading data from database</exception>
    /// <exception cref="Exception">Could not find any matching data.</exception>
    /// <returns>A nested array of all entries returned by the query.</returns>
    public object[][] GetDataFromDatabase(string query)
    {
        List<object[]> data = new List<object[]>();
        _connection.Open();
        using (MySqlCommand command = new MySqlCommand(query, _connection))
        {
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
        _connection.Close();

        if (data.Count == 0)
        {
            throw new Exception("Could not find data from database.");
        }
        return data.ToArray();
    }
}