using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst.PL;
using Bestellsystem_Lieferdienst_Client.PL;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client
{
    public partial class StartForm : UserControl
    {
        public StartForm()
        {
            InitializeComponent();
            InitializeManualComponent();
            //https://learn.microsoft.com/en-us/dotnet/api/System.Guid?view=net-9.0
            GetAndInitData();
        }

        void GetAndInitData()
        {
            //TODO:should the data filtered on the client or directly at the server?
            cbxCategory.Items.Add("Alle");
            cbxCategory.SelectedIndex = 0;
            foreach (var VARIABLE in GetData.GetAllProductCategories())
            {
                cbxCategory.Items.AddRange(VARIABLE);
            }

            //Product[] x = GetData.GetAllProducts();
            //productsView.SetItems(x);
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            this.LoadView(new LoginUserControl());
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            this.LoadView(new SignupUserControl());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_SucheBestätigen_Click(object sender, EventArgs e)
        {
            productsView.ApplyFilter(textBox1.Text, cbxCategory.SelectedItem.ToString());
        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            productsView.ApplyFilter(textBox1.Text, cbxCategory.SelectedItem.ToString());
        }
    }
}