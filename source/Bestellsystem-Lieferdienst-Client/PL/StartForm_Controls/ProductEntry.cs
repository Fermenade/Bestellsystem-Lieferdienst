using Bestellsystem_Lieferdienst_Client.BL.ShopingCart;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL.StartForm_Controls;

public partial class ProductEntry : UserControl
{
    public ProductEntry(Product product)
    {
        InitializeComponent();
        using (MemoryStream ms = new MemoryStream(product.picture))
        {
            // Create an image from the byte array
            pBXProduct2.Image = Image.FromStream(ms);
        }
        this.lbxProduct2Name.Text = product.Name;
        this.lbxProduct2Price.Text = $"{product.Price:C}";
        this.btnProduct2AddToCart.Click += (o, s) =>
        {
            CartManager.AddProduct(product);
        };
    }
}