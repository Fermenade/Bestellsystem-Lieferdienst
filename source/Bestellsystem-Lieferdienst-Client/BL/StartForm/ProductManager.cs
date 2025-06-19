using Client_Server_Code_Library;
using System.ComponentModel;

namespace Bestellsystem_Lieferdienst_Client.BL.StartForm
{
    public class ProductManager
    {
        public static BindingList<Product> ProductItemsCache { get; } = new();

        public static void AddProduct(Product product)
        {
            if (ProductItemsCache.Any(i => i.ProductId == product.ProductId)) throw new ArgumentException("Product already enlisted");
            ProductItemsCache.Add(product);
        }
        public static void AddProducts(IEnumerable<Product> products)
        {
            foreach (Product productItem in products)
            {
                AddProduct(productItem);
            }
        }
        public static void RemoveProduct(Product product)
        {
            var item = ProductItemsCache.FirstOrDefault(ci => ci.Name == product.Name);
            if (item != null)
            {
                ProductItemsCache.Remove(item);
            }
        }
        public static void Clear()
        {
            ProductItemsCache.Clear();
        }
    }
}
