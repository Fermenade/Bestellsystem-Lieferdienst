using Newtonsoft.Json;

namespace Client_Server_Code_Library;

public class User
{
    public int UserID;
    public int UsertypeID = 0;//Default Value
    public string FirstName; //TODO: Update Database so that name is not necessary.
    public string LastName;
    public string Email;
    public string Password;
    public Address Address;

    [JsonConstructor]
    public User(int userId, int usertypeId, string firstName, string lastName, string email, string password)
        : this(firstName, lastName, email, password)
    {
        UserID = userId;
        UsertypeID = usertypeId;
    }
    public User(string email, string password) : this(null, null, email, password)
    {
    }
    public User(string firstName, string lastName, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        if (email == "") throw new("Email is empty");
        Email = email;
        if (password == "") throw new("Password is empty");
        Password = password;
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


