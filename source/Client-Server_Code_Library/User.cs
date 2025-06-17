using Newtonsoft.Json;

namespace Client_Server_Code_Library;

public class User
{
    public long userID;
    public int usertypeID = 0;//Default Value
    public string email;
    public string password;
    public long? address_addressID;

    [IgnoreInsert]
    public Address? Address;

    [JsonConstructor]
    public User(long userId, int usertypeId, string email, string password, Address? address)
        : this(email, password)
    {
        userID = userId;
        usertypeID = usertypeId;
        Address = address;
    }

    [DatabaseConstructor]
    public User(long userId, int usertypeId, string email, string password, long? addressID)//This constructor is just for the database
        : this(email, password)
    {
        userID = userId;
        usertypeID = usertypeId;
        //address_addressID = addressID.GetType();
    }
    public User(string email, string password)
    {
        if (email == "") throw new("Email is empty");
        this.email = email;
        this.password = password;//Yes, user can have empty password.
    }

    public override string ToString()
    {
        return JsonSerialize.Serialize(this);
    }
}


