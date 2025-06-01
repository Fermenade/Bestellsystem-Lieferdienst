using Client_Server_Code_Library;
using System.ComponentModel;

namespace Bestellsystem_Lieferdienst.BL.ShopingCart
{
    //Generated
    public static class CartManager
    {
        public static BindingList<CartItem> CartItems { get; } = new();

        public static void AddProduct(Product product)
        {
            var existing = CartItems.FirstOrDefault(ci => ci.Product.Name == product.Name);
            if (existing != null)
            {
                existing.Quantity++;
            }
            else
            {
                CartItems.Add(new CartItem(product));
            }
        }

        public static void RemoveProduct(Product product)
        {
            var item = CartItems.FirstOrDefault(ci => ci.Product.Name == product.Name);
            if (item != null)
            {
                CartItems.Remove(item);
            }
        }
    }
}
