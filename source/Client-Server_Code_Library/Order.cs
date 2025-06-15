namespace Client_Server_Code_Library;
public class Order
{
    int? OrderID;
    int UserID;
    OrderItem[] Items;
    DateTime DateTime;

    Address Übergabeort;


    public Order(int orderID, int userId, OrderItem[] items, DateTime dateTime)
    {
        OrderID = orderID;
        UserID = userId;
        Items = items;
        DateTime = dateTime;
    }

    public static Order CreateOrder(OrderItem items, DateTime dateTime)
    {
        Order order = new Order();


        return order;
    }
}