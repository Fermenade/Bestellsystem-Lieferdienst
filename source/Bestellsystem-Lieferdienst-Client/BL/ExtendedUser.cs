using Bestellsystem_Lieferdienst_Client.BL;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.BL
{
    public class ExtendedUser : User
    {
        public ExtendedUser(string email, string password)
        {

            if (email == "") throw new("Email is empty");
            Email = email;
            Password = password.ToSHA256();
        }

        public static User CreateUser(string email, string password)
        {
            return new ExtendedUser(email, password);
        }
    }
}
