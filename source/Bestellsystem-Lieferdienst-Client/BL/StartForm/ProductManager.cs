using Client_Server_Code_Library;
using System.ComponentModel;

namespace Bestellsystem_Lieferdienst_Client.BL.StartForm
{
    public class ProductManager
    {
        public static BindingList<Product> ProductItemsCache { get; } = new();

        public static void AddProduct(Product product)
        {
            ProductItemsCache.Add(product);
        }

        public static void RemoveProduct(Product product)
        {
            var item = ProductItemsCache.FirstOrDefault(ci => ci.Name == product.Name);
            if (item != null)
            {
                ProductItemsCache.Remove(item);
            }
        }
    }
}
