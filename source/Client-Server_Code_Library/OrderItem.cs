namespace Client_Server_Code_Library
{
    public class OrderItem
    {
        [DatabaseAutoIncrementID] public long? OrderId;
        public Product Product { get; set; }
        public int quantity { get; set; }
    }
}
