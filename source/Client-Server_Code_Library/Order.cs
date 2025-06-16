using System;

namespace Client_Server_Code_Library;
public class Order
{
    public int? OrderID;
    public int? UserID;
    [IgnoreInsert]
    public OrderItem[]? Items;
    public DateTime DateTime;
    public State OrderState = State.NotStarted;

    public string? Address;

    [DatabaseConstructor]
    public Order(int orderID, int? userId, int state, DateTime dateTime, string address) : this(userId, dateTime, address)
    {
        OrderID = orderID;
        OrderState = (State)state;
    }

    public Order(int? userId, OrderItem[] items, DateTime dateTime, string address)
    {
        UserID = userId;
        Items = items;
        DateTime = dateTime;
        Address = address;
    }
    public Order(int? userId, DateTime dateTime, string address)
    {
        UserID = userId;
        DateTime = dateTime;
        Address = address;
    }

    public static Order CreateOrder(Address address, OrderItem[] items, User? user = null)
    {
        return new Order(user?.userID, items, DateTime.Now, address.ToString());
    }
    public enum State
    {
        NotStarted,
        InProgress,
        Finished,
        Delivered
    }
}