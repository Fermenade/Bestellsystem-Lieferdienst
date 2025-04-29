using System.Data;
using Bestellsystem_Lieferdienst.BL;
using MySql.Data.MySqlClient;

namespace Bestellsystem_Lieferdienst.DAL;

public class DatabaseHelper(string connectionString)
{
    private MySqlConnection _connection = new(connectionString); //if this fails database couldn't be reached.

    public void InsertIntoTable<T>(string tableName, List<T> items) where T : class
    {
        //Generated
        if (_connection == null || String.IsNullOrEmpty(tableName))
            throw new ArgumentException(); // Validate input parameters

        foreach (var item in items)
        {
            var properties = typeof(T).GetProperties();
            string columns = String.Join(", ", properties.Select(p => p.Name));
            string valuesPlaceholder = String.Join(", ", Enumerable.Repeat("@" + "{0}", properties.Length)
                .ToArray());

            var cmd = $"INSERT INTO '{tableName}' ({columns}) VALUES ({items.ToString()});";

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
                    Console.WriteLine("Failed to insert item: " + item);
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }

    void InsertDataIntoDatabase(object[] data, string table)
    {
        // INSERT INTO `benutzer` (`benutzerID`, `benutzerrtypID`, `vorname`, `nachname`, `e-mail`, `passwort`)
        // VALUES('[value-1]','[value-2]','[value-3]','[value-4]','[value-5]','[value-6]')
        // """;}
    }

    public int ExecuteNonQuery(string query)
    {
        _connection.Open();
        using (MySqlCommand command = new MySqlCommand(query, _connection))
        {
            _connection.Close();
            return command.ExecuteNonQuery(); //TODO: Make it run async
        }
    }


    T GetDataFromID<T>(int id, string tableName)where T:class
    {
        string sql = $"""SELECT * FROM {tableName} WHERE {tableName}ID = {id}""";
        var i = GetDataFromDatabase<T>(sql);
        if (i.Length == 1)
        {
            return i[0];
        }
        return null;
    }
    /// <summary>
    /// Takes a sql query, executes it and returns the output as an array of provided Type.
    /// </summary>
    /// <param name="query">The sql query</param>
    /// <typeparam name="T">T must be of type class. The type the data should be converted into.</typeparam>
    /// <remarks>The types FIRST constructor has to be the type that takes all arguments that the database row returns.</remarks>
    /// <exception>If types first constructor doesn't satisfy all values from the database. Exception will be thrown.</exception>
    /// <returns>Returns all rows selected from the database converted into the provided type</returns>
    public T[] GetDataFromDatabase<T>(string query) where T : class
    {
        //Generated
        List<T> results = [];

        var constructor = typeof(T).GetConstructors()[0];
        var parameters = constructor.GetParameters();
        var args = new object[parameters.Length];
        var o = GetDataFromDatabase(query);
        foreach (var VARIABLE in o)
        {
            for (int i = 0; i < parameters.Length; i++)
            {
                // Get the value from the reader and convert it to the appropriate type
                var value = VARIABLE[i];
                args[i] = Convert.ChangeType(value, parameters[i].ParameterType);
            }
            // Create an instance of T using the constructor and the arguments
            var instance = (T)constructor.Invoke(args);
            results.Add(instance);
        }

        return results.ToArray();
    }
/// <summary>
/// Takes a sql query, executes it and returns the output as two-dimensional object array.
/// </summary>
/// <param name="query">The sql query</param>
/// <returns>A nested array of all entries returned by the query</returns>
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
                        object result = Convert.ChangeType(reader.GetValue(i), reader.GetFieldType(i));
                        temp.Add(result);
                    }

                    data.Add(temp.ToArray());
                }
            }
        }

        _connection.Close();

        return data.ToArray();
    }
}