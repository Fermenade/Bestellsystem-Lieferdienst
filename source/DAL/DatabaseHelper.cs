using System.Data;
using MySql.Data.MySqlClient;

namespace Bestellsystem_Lieferdienst.DAL;

public class DatabaseHelper(string connectionString)
{
    private MySqlConnection _connection = new(connectionString); //if this fails database couldn't be reached.
    
    public int ExecuteNonQuery(string query)
    {
        _connection.Open();
        using (MySqlCommand command = new MySqlCommand(query, _connection))
        {
            _connection.Close();
            return command.ExecuteNonQuery();//TODO: Make it run async
        }
    }


    object GetDataFromID(int id, string tableName)
    {
        throw new NotImplementedException();
        return new();
    }

    public T GetDataFromDatabase<T>(string query)
    {
        var i = GetDataFromDatabase(query);
        //DataTable
        foreach (DataRow item in i)
        {
            foreach (var column in item.ItemArray)
            {
            }
        }

        return default;
    }

    public DataRowCollection GetDataFromDatabase(string query)
    {
        List<object> data = new List<object>();
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
                        // DataTable i =  reader[];
                        // reader.GetFieldType(i);
                        var result = Convert.ChangeType(reader.GetValue(i), reader.GetFieldType(i));
                        Console.WriteLine(result); // prints: 123
                        temp.Add(result);
                    }

                    data.Add(temp);
                }
            }
        }

        _connection.Close();
        return null;
    }
}