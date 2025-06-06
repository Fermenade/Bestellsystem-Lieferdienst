using Bestellsystem_Lieferdienst.BL.ShopingCart;
using Bestellsystem_Lieferdienst.Server;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.BL
{
    public static class GetData
    {
        public static Product[] GetAllProducts() => Client.client.SendAndReturn<Product[]>("GET ALLPRODUCTS");

        public static Product GetProduct(int id) => Client.client.SendAndReturn<Product>($"GET PRODUCT {id}");

        public static User GetUser(string username, string password) =>
            Client.client.SendAndReturn<User>($"GET USER '{username} {password}'");

        public static ProductCategory[] GetAllProductCategories() =>
            Client.client.SendAndReturn<ProductCategory[]>("GET ALLCATEGORIES");

        public static bool SetUser(User user) => Client.client.SendAndReturn<bool>("SET USER " + user);
        public static bool SetOrder(CartItem[] items) => Client.client.SendAndReturn<bool>("SET ORDER "+items);

        public static bool UpdateUser(User user) => Client.client.SendAndReturn<bool>("UPDATE USER " + user);
        //public static User GetUser(string email, string password) => Client.client.SendAndReturn<User>("GET USER ");
    }
}
