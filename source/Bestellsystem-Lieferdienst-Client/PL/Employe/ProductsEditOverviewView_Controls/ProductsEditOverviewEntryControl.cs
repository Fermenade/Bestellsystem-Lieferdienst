using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL.Employe.ProductsEditOverviewView_Controls
{
    public partial class ProductsEditOverviewEntryControl : UserControl
    {
        public Product Product;
        public ProductsEditOverviewEntryControl(Product product)
        {
            InitializeComponent();
            this.Product = product;

            lb_Name.Text = product.Name;
            lb_description.Text = product.Description;
            lb_price.Text = $"{product.Price:C}";
        }
    }
}
