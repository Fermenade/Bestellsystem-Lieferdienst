namespace Client_Server_Code_Library;
public class Order
{
    public int? OrderID;
    public int? UserID;
    public OrderItem[] Items;
    public DateTime DateTime;

    public Address? Address;

    [DatabaseConstructor]
    public Order(int orderID, int? userId, OrderItem[] items, DateTime dateTime, Address address) : this(userId, items, dateTime, address)
    {
        OrderID = orderID;
    }

    public Order(int? userId, OrderItem[] items, DateTime dateTime, Address address)
    {
        UserID = userId;
        Items = items;
        DateTime = dateTime;
        Address = address;
    }

    public static Order CreateOrder(Address address, OrderItem[] items, User? user = null)
    {
        return new Order(user?.userID, items, DateTime.Now, address);
    }
}