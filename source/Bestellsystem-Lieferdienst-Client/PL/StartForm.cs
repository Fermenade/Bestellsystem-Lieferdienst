using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst.BL.ShopingCart;
using Bestellsystem_Lieferdienst.PL;
using Bestellsystem_Lieferdienst_Client.PL;

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
            cbxCategory.Items.Add("Alle");
            cbxCategory.SelectedIndex = 0;
            foreach (var VARIABLE in GetData.GetAllProductCategories())
            {
                cbxCategory.Items.Add(VARIABLE);
            }

            for (int i = 0; i < 40; i++)
            {
                CartManager.AddProduct(new($"Name{i}", "description", 12, [""]));
            }

            //GetData.GetAllProducts();
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

        private void StartForm_Load(object sender, EventArgs e)
        {

        }
    }
}