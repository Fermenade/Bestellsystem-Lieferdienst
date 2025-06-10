using Bestellsystem_Lieferdienst_Client.BL.ShopingCart;
using Bestellsystem_Lieferdienst_Client.Server;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.BL
{
    public static class GetData
    {
        public static Task<Product[]> GetAllProducts() => Client.client.SendAndReturnAsync<Product[]>("GET ALLPRODUCTS");

        public static Task<Product> GetProduct(int id) => Client.client.SendAndReturnAsync<Product>($"GET PRODUCT {id}");

        public static Task<User> GetUser(User user) =>
            Client.client.SendAndReturnAsync<User>($"GET USER {user}");

        public static Task<ProductCategory[]> GetAllProductCategories() => Client.client.SendAndReturnAsync<ProductCategory[]>("GET ALLCATEGORIES");

        public static Task<bool> SetUser(User user) => Client.client.SendAndReturnAsync<bool>("SET USER " + user);
        public static Task<bool> SetOrder(CartItem[] items) => Client.client.SendAndReturnAsync<bool>("SET ORDER " + items);

        public static Task<bool> UpdateUser(User user) => Client.client.SendAndReturnAsync<bool>("UPDATE USER " + user);
        //public static User GetUser(string email, string password) => Client.client.SendAndReturn<User>("GET USER ");
    }
}
