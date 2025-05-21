using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst.PL;
using Bestellsystem_Lieferdienst_Client.PL;
using System.Diagnostics;

namespace Bestellsystem_Lieferdienst_Client
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
            InitializeManualComponent();
            //https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=net-9.0

        }

        //Generated
        //End

        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.LoadView(new LoginUserControl());
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.LoadView(new SignupUserControl());
        }

        private void pBXProduct1Click(object sender, EventArgs e)
        {

        }

        private void lblProduct1Name_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
        }

        // private void btnRegister_Click(object sender, EventArgs e)
        // {
        //     LoadView(new RegisterUserControl());
        // }
        //         void GetDataFromDatabase()
        //         {
        //             DatabaseHelper dbHelper = new DatabaseHelper(connectionString);
        //             var u = dbHelper.GetDataFromID<User>(6, "user");
        //             Console.WriteLine(u);
        //             // string query = "SELECT * FROM `user`";
        //             // var a = dbHelper.GetDataFromDatabase<Address>(query);
        //             // foreach (var item in a)
        //             // {
        //             //     Console.WriteLine(item.ToString());
        //             // }
        //         }
        //
        //         void InsertDefaultData()
        //         {
        //             DatabaseHelper database = new(connectionString);
        //             List<string> Usertyp = new List<string>() { "Customer", "Employee", "Admin" };
        //
        //                 foreach (string VARIABLE in Usertyp)
        //                 {
        //                     string data = $"""
        //                                    INSERT INTO `benutzertyp`(`name`)
        //                                    VALUES ({VARIABLE})
        //                                    """;
        //
        //                     database.ExecuteNonQuery(data);
        //                 }
        //         }
    }
}