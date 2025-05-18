using Bestellsystem_Lieferdienst_Client.BL;

namespace Bestellsystem_Lieferdienst_Client.PL;

public partial class ShoppingCart : UserControl
{
    static List<UserProduct> products;
    public ShoppingCart()
    {
        InitializeComponent();
    }
    public void AddItem(UserProduct p)
    {
        products.Add(p);
    }
}

public class UserProduct
{
    Product product;
    uint ammount;
}