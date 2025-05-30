using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL;

public partial class ShoppingCart : UserControl
{
    static List<UserProduct> products;
    private int spacing = 100;
    public ShoppingCart()
    {
        InitializeComponent();
    }
    public void AddItem(Product p)
    {
        products.Add(new(p));
    }
}

public class UserProduct
{
    Product product;
    uint ammount;
    public UserProduct(Product product)
    {
        this.product = product;
        this.ammount = 1;
    }
}