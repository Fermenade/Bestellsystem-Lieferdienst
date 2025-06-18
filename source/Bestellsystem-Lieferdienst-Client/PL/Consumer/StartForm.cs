using Bestellsystem_Lieferdienst.PL;
using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.PL.Employe;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL
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

        async void GetAndInitData()
        {
            //TODO:should the data filtered on the client or directly at the server?
            cbxCategory.Items.Add("Alle");
            ProductCategory[]? array = await ServerData.GetAllProductCategories();
            for (int i = 0; i < array?.Length; i++)
            {
                ProductCategory? VARIABLE = array[i];
                cbxCategory.Items.Add(VARIABLE.name);
            }

            Product[] x = await ServerData.GetAllProducts() ?? [];
            productsView.SetItems(x);
            cbxCategory.SelectedIndex = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadView(new UserDetailView());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LoadView(new ProductsEditOverviewView());
        }
    }
}