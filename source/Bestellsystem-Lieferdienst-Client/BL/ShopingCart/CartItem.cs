using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.BL.ShopingCart;

using System.ComponentModel;

public class CartItem : OrderItem, INotifyPropertyChanged
{

    public CartItem(Product product)
    {
        this.Product = product;
    }

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

    public decimal TotalPrice => this.Product.Price * Quantity;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
        => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    public override string ToString()
    {
        return JsonSerialize.Serialize(this);
    }
}
