using System.Data;
using Microsoft.Data.SqlClient;
using System.Data.SqlClient;

namespace Bestellsystem_Lieferdienst.DAL;
public class DatabaseHelper
{
    private string connectionString;

    public DatabaseHelper(string connectionString)
    {
        this.connectionString = connectionString;
    }
    public int InsertDataIntoDatabase(string query)
    {
        
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    return command.ExecuteNonQuery();
                }
        }
    }
// Replace with your server name, database name and credentials.

    public T[] GetDataFromDatabase<T>(string connectionString, string query)
    {
        List<T> data = new List<T>();
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Console.Write("{0}", reader[0]); // Prints the first column of each record. Change to
                            if (data == null) throw new Exception("Error reading data from database");
                            data.Add((T)reader.GetValue(0));
                        }
                    }
                }
        }
        return data.ToArray();
    }
}