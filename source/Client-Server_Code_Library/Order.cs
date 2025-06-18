namespace Client_Server_Code_Library;
public class Order
{
    [DatabaseID]
    public long? OrderID;
    public long? UserID;
    [IgnoreInsert]
    public OrderItem[]? Items;
    public DateTime DateTime;
    public State OrderState = State.NotStarted;

    public string? Address;

    [DatabaseConstructor]
    public Order(long orderID, long? userId, int state, DateTime dateTime, string address) : this(userId, dateTime, address)
    {
        OrderID = orderID;
        OrderState = (State)state;
    }

    public Order(long? userId, OrderItem[] items, DateTime dateTime, string address)
    {
        UserID = userId;
        Items = items;
        DateTime = dateTime;
        Address = address;
    }
    public Order(long? userId, DateTime dateTime, string address)
    {
        UserID = userId;
        DateTime = dateTime;
        Address = address;
    }

    public static Order CreateOrder(Address address, OrderItem[] items, User? user = null)
    {
        return new Order(user?.UserId, items, DateTime.Now, address.ToString());
    }
    public enum State
    {
        NotStarted,
        InProgress,
        Finished,
        Delivered
    }
}