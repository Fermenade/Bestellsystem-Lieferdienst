using Newtonsoft.Json;

namespace Client_Server_Code_Library;

public class User
{
    public int userID;
    public int usertypeID = 0;//Default Value
    public string email;
    public string password;
    public int? address_addressID;

    [IgnoreInsert]
    public Address? Address;

    [JsonConstructor]
    public User(int userId, int usertypeId, string email, string password, Address? address)
        : this(email, password)
    {
        userID = userId;
        usertypeID = usertypeId;
        Address = address;
    }
    public User(string email, string password)
    {
        if (email == "") throw new("Email is empty");
        email = email;
        if (password == "") throw new("Password is empty");
        password = password;
    }

    public override string ToString()
    {
        return JsonSerialize.Serialize(this);
    }
}


