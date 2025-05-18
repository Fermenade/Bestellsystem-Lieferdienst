namespace Bestellsystem_Lieferdienst_Client.BL;
public class User
{
    public int? UserID;
    public int UsertypeID = 0;//Default Value
    public string? FirstName; //TODO: Update Database so that name is not necessary.
    public string? LastName;
    public string Email;
    public string Password;
    public Address? Address;
    public User(int userId, int usertypeId, string firstName, string lastName, string email, string password)
        : this(firstName, lastName, email, password)
    {
        this.UserID = userId;
        this.UsertypeID = usertypeId;
    }
    public User(string email, string password) : this(null, null, email, password)
    {
    }
    public User(string? firstName, string? lastName, string email, string password)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        if (email == "") throw new("Email is empty");
        this.Email = email;
        if (password == "") throw new("Password is empty");
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