namespace Bestellsystem_Lieferdienst_Server.BL.Datatypes;

public class Product_Productgroup
{
    public long ProductID { get; private set; }
    public long ProductGroupID { get; private set; }

    public Product_Productgroup(long productID, long productGroupID)
    {
        ProductID = productID;
        ProductGroupID = productGroupID;
    }
}