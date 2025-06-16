using Bestellsystem_Lieferdienst_Client.Server;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.BL
{
    public static class ServerData
    {
        //———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        //GET
        //———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        public static Task<Product[]> GetAllProducts() => Client.client.SendAndReturnAsync<Product[]>("GET ALLPRODUCTS");
        public static Task<Product> GetProduct(int id) => Client.client.SendAndReturnAsync<Product>($"GET PRODUCT {id}");
        public static Task<User> GetUser(User user) =>
            Client.client.SendAndReturnAsync<User>($"GET USER {user}");
        public static Task<ProductCategory[]> GetAllProductCategories() => Client.client.SendAndReturnAsync<ProductCategory[]>("GET ALLCATEGORIES");
        public static Task<Order[]> GetAllOrders() => Client.client.SendAndReturnAsync<Order[]>("GET ALLORDERS");


        //———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        //SET
        //———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        public static Task<User> SetUser(User user) => Client.client.SendAndReturnAsync<User>("SET USER " + user);
        public static Task<bool> SetOrder(Order order) => Client.client.SendAndReturnAsync<bool>("SET ORDER " + order);
        public static Task<Product> SetProduct(Product product) => Client.client.SendAndReturnAsync<Product>("SET PRODUCT "+ product);


        //———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        //UPDATE
        //———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        public static Task<bool> UpdateUser(User user) => Client.client.SendAndReturnAsync<bool>("UPDATE USER " + user);
        public static Task<bool> UpdateProduct(Product product) =>
            Client.client.SendAndReturnAsync<bool>("UPDATE PRODUCT " + product);


        //———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        //UPDATE
        //———————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————————
        public static Task<bool> DeleteOrder(Order order) =>
            Client.client.SendAndReturnAsync<bool>("DELETE ORDER " + order);

        public static Task<bool> DeleteProduct(Product product) =>
            Client.client.SendAndReturnAsync<bool>("DELETE PRODUCT " + product);

        //public static User GetUser(string email, string password) => Client.client.SendAndReturn<User>("GET USER ");
    }
}
