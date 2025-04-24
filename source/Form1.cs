using Bestellsystem_Lieferdienst.DAL;
using Microsoft.Data.SqlClient;

namespace Bestellsystem_Lieferdienst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //InsertDummyData();
            InsertDefaultData();
        }

        void InsertDummyData()
        {
            string data = """
                          INSERT INTO `benutzer` (`benutzerID`, `benutzerrtypID`, `vorname`, `nachname`, `e-mail`, `passwort`)
                          VALUES('[value-1]','[value-2]','[value-3]','[value-4]','[value-5]','[value-6]')
                          """;
        }

        void InsertDefaultData()
        {
            string connectionString = "Server=localhost;Database=lieferservice;User ID=root;Password=;";

            string databaseConnectionString = connectionString;
            
            DatabaseHelper database = new(databaseConnectionString);
            List<string> Usertyp = new List<string>() { "Customer", "Employee", "Admin"};
            for (int i = 0; i < 10; i++)
            {
                foreach (var VARIABLE in Usertyp)
                {
                    string data = $"""
                                  INSERT INTO `benutzertyp`(`name`)
                                  VALUES ({VARIABLE})
                                  """;
                    
                database.InsertDataIntoDatabase(data);
                }
                using (var connection = new SqlConnection(connectionString))
                {
                }

            }
        }
    }
}
