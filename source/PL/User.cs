namespace Bestellsystem_Lieferdienst.PL;

public struct User
{
    int UserID;
    string FirstName;
    string LastName;
    string Email;
    Address Address;
    string Password;
}

public struct Address
{
    int AddressID;
    string Country;
    int ZippCode;
    string City;
    string Street;
    int HouseNumber;
    int? ApartmentNumber;
}

public struct Receipe
{
    int ReceipeID;
    int UserID;
    private int[] productsID;
    DateTime Datum;
    private string Übergabeort;
    //TODO: Product should be quantisisable :)
}

public struct Product
{
    int ProductID;
    string ProductName;
    string ProductDescription;
    int ProductPrice;
    ProductCategory[] ProductCategories;
}

public class ProductCategory
{
    int CategoryID;
    string CategoryName;
}