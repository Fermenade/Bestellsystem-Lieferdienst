using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst.BL.ShopingCart;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.PL
{
    public partial class ProductDetailView : UserControl
    {
        private Product product;
        public ProductDetailView(Product product)
        {
            this.product = product;
            InitializeComponent();

            lbl_ProductName.Text = product.Name;
            lbl_BeschreibungInhalt.Text = product.Description;
            lbl_ProductPrice.Text = $"{this.product.Price:C}";
            InitializeManualComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_BeschreibungÜberschrift_Click(object sender, EventArgs e)
        {

        }

        private void lbl_BeschreibungInhalt_Click(object sender, EventArgs e)
        {

        }

        private void btn_BackToMain2_Click(object sender, EventArgs e)
        {
            this.LoadView(new Bestellsystem_Lieferdienst_Client.StartForm());
        }

        private void btn_WarenkorbProduktAnsicht_Click(object sender, EventArgs e)
        {
            CartManager.AddProduct(product);
        }

        private void btn_Kaufen_Click(object sender, EventArgs e)
        {
            this.LoadView(new CheckoutForm());
        }
    }
}
