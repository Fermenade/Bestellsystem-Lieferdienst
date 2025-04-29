namespace Bestellsystem_Lieferdienst.BL;
public class User
{
    public int? UserID;
    public int UsertypeID = 0;//Default Value
    public string? FirstName; //TODO: Update Database so that name is not necessary.
    public string? LastName;
    public string Email;
    public string Password;
    public Address? Address;
    //The Database Constructor HAS to be the first constructor!
    public User(int userId, int usertypeId, string firstName, string lastName, string email, string password)
        :this(firstName,lastName,email,password)
    {
        this.UserID=userId;
        this.UsertypeID=usertypeId;
    }
    public User(string email, string password) : this(null, null, email, password)
    {
    }
    public User(string? firstName, string? lastName, string email, string password)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        if(email=="")throw new ("Email is empty");
        this.Email = email;
        if(password=="")throw new ("Password is empty");
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
    
    //The Database Constructor HAS to be the first constructor!
    Address(int? addressId, string country, int zippCode, string city, string street, int houseNumber, int apartmentNumber)
        : this(country, zippCode, city, street, houseNumber, apartmentNumber)
    {
        this.AddressID=addressId;
    }
    public Address(string country, int zipCode, string city, string street, int houseNumber, int apartmentNumber)
        :this(country,zipCode,city,street,houseNumber)
    {
        if(apartmentNumber==0)throw new ("Invalid apartment number");
        this.ApartmentNumber=apartmentNumber;
    }
    public Address(string country, int zippCode, string city, string street, int houseNumber)
    {
        if(country=="")throw new ("Invalid country");
        this.Country = country;
        if(zippCode==0)throw new ("Invalid zipp number");
        this.ZippCode = zippCode;
        if(city=="")throw new ("Invalid city");
        this.City = city;
        if(street=="")throw new ("Invalid street");
        this.Street = street;
        if(houseNumber==0)throw new ("Invalid house number");
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
        if(ApartmentNumber!=null)
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