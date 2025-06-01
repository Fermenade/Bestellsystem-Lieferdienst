using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.BL.ShopingCart;

using System.ComponentModel;

public class CartItem : INotifyPropertyChanged
{
    private int quantity = 1;

    public CartItem(Product product)
    {
        Product = product;
    }
    public Product Product { get; set; }

    public int Quantity
    {
        get => quantity;
        set
        {
            if (quantity != value)
            {
                if (value != 0)
                {
                    quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                    OnPropertyChanged(nameof(TotalPrice));
                }
            }
        }
    }

    public decimal TotalPrice => Product.Price * Quantity;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}
