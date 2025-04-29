using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst.DAL;
using Bestellsystem_Lieferdienst.PL;
using MySql.Data.MySqlClient;

namespace Bestellsystem_Lieferdienst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeManualComponent();
            //InsertDummyData();
            GetDataFromDatabase();
            //InsertDefaultData();
        }

        //Generated
        private void LoadView(UserControl view)
        {
            Controls.Clear();
            view.Dock = DockStyle.Fill;
            Controls.Add(view);
        }
        //End

        private void btn_Login_Click(object sender, EventArgs e)
        {
            LoadView(new LoginUserControl());
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            LoadView(new SignupUserControl());
        }

        // private void btnRegister_Click(object sender, EventArgs e)
        // {
        //     LoadView(new RegisterUserControl());
        // }

        void InsertDummyData()
        {
            string data = """
                          INSERT INTO `benutzer` (`benutzerID`, `benutzerrtypID`, `vorname`, `nachname`, `e-mail`, `passwort`)
                          VALUES('[value-1]','[value-2]','[value-3]','[value-4]','[value-5]','[value-6]')
                          """;
        }

        string connectionString = "Server=localhost;Database=deliveryservice;Uid=root";

        void GetDataFromDatabase()
        {
            DatabaseHelper dbHelper = new DatabaseHelper(connectionString);
            string query = "SELECT * FROM `user`";
            var sd = dbHelper.GetDataFromDatabase(query);
            var a = dbHelper.GetDataFromDatabase<User>(query);
            foreach (var item in a)
            {
                Console.WriteLine(item.ToString());
            }
        }

        void InsertDefaultData()
        {
            DatabaseHelper database = new(connectionString);
            List<string> Usertyp = new List<string>() { "Customer", "Employee", "Admin" };

                foreach (string VARIABLE in Usertyp)
                {
                    string data = $"""
                                   INSERT INTO `benutzertyp`(`name`)
                                   VALUES ({VARIABLE})
                                   """;

                    database.ExecuteNonQuery(data);
                }
        }
    }
}