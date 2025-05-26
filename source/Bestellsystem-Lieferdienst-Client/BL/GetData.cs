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

        public static string[] GetAllProductCategories() =>
            Client.client.SendAndReturn<string[]>("GET ALLCATEGORIES");

        public static void SetUser(User user) => Client.client.SendAndReturn<object>("SET USER " + user);

        //public static User GetUser(string email, string password) => Client.client.SendAndReturn<User>("GET USER ");
    }
}
