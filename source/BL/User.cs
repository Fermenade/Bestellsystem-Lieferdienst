namespace Bestellsystem_Lieferdienst.BL;
public class User
{
    public int? UserID;
    public int UsertypeID = 1;//Default Value
    public string? FirstName; //TODO: Update Database so that name is not necessary.
    public string? LastName;
    public string Email;
    public string Password;
    public Address? Address;
    public User(string email, string password):this(null,null, email,password)
    { }
    public User(int userId, int usertypeId, string firstName, string lastName, string email, string password)
        :this(firstName,lastName,email,password)
    {
        this.UserID=userId;
        this.UsertypeID=usertypeId;
    }
    public User(string? firstName, string? lastName, string email, string password)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Email = email;
        this.Password = password;
    }
    
    public override string ToString()
    {
        List<string> str = new List<string>();
        
        if (FirstName != null)
        {
            str.Add($"'{FirstName}'");
        }
        if (LastName != null)
        {
            str.Add($"'{LastName}'");
        }
        str.Add($"'{Email}'");
        str.Add($"'{Password}'");
        
        return string.Join(",", str);
    }
}

public struct Usertype
{
    int UsertypeID;
    string Name;
}

public class Address
{
    int? AddressID;
    public string Country;
    public int ZippCode;
    public string City;
    public string Street;
    public int HouseNumber;
    public int? ApartmentNumber;

    Address(int? addressId, string country, int zippCode, string city, string street, int houseNumber, int apartmentNumber)
        : this(country, zippCode, city, street, houseNumber)
    {
        this.AddressID=addressId;
        this.ApartmentNumber = apartmentNumber;
    }
    Address(string country, int zipCode, string city, string street, int houseNumber, int apartmentNumber)
        :this(country,zipCode,city,street,houseNumber)
    {
        this.ApartmentNumber=apartmentNumber;
    }
    Address(string country, int zippCode, string city, string street, int houseNumber)
    {
        this.Country = country;
        this.ZippCode = zippCode;
        this.City = city;
        this.Street = street;
        this.HouseNumber = houseNumber;
    }
    
    public override string ToString()
    {
        List<string> str = new List<string>();
        str.Add($"'{Country}'");
        str.Add($"'{ZippCode}'");
        str.Add($"'{City}'");
        str.Add($"'{Street}'");
        str.Add($"'{HouseNumber}'");
        str.Add($"'{ApartmentNumber}'");
        return string.Join(",",str);
    }
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