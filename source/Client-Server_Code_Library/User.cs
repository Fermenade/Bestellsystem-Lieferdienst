using Newtonsoft.Json;

namespace Client_Server_Code_Library;

public class User
{
    public long? UserId;
    public int UsertypeID = 0;//Default Value
    public string Email;
    public string Password;
    public long? Address_addressID;

    [IgnoreInsert]
    public Address? Address;

    [JsonConstructor]
    public User(long userId, int usertypeId, string email, string password, Address? address)
    {
        UserId = userId;
        UsertypeID = usertypeId;
        Address = address;
        Email = email;
        Password = password;
    }

    [DatabaseConstructor]
    public User(long userId, int usertypeId, string email, string password, long? addressID)//This constructor is just for the database
    {
        UserId = userId;
        UsertypeID = usertypeId;
        Email = email;
        Password = password;
        Address_addressID = addressID;
    }

    protected User()
    {
        //This constructor has to be empty
    }

    public override string ToString()
    {
        return JsonSerialize.Serialize(this);
    }
}


