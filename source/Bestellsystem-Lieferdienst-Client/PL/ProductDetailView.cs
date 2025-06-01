using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.PL
{
    public partial class ProductDetailView : UserControl
    {
        public ProductDetailView(Product product)
        {
            InitializeComponent();

            lbl_ProductName.Text = product.Name;
            lbl_BeschreibungInhalt.Text = product.Description;
            lbl_ProductPrice.Text = $"{product.Price:C}";
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
    }
}
