using Bestellsystem_Lieferdienst.BL.ShopingCart;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.PL.StartForm
{
    public partial class ProductEntry : UserControl
    {
        public ProductEntry(Product product)
        {
            InitializeComponent();
            this.lbxProduct2Name.Text = product.Name;
            this.lbxProduct2Price.Text = product.Price.ToString();
            this.btnProduct2AddToCart.Click += (o, s) =>
            {
                CartManager.AddProduct(product);
            };
        }
    }
}
