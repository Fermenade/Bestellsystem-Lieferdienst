using Bestellsystem_Lieferdienst.BL;

namespace Bestellsystem_Lieferdienst.PL;

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