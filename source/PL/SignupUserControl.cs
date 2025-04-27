using System.Security.Cryptography;
using System.Text;
using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst.DAL;

namespace Bestellsystem_Lieferdienst.PL;

public partial class SignupUserControl : UserControl
{
    public SignupUserControl()
    {
        InitializeComponent();
        //InitializeManualComponent();
    }

    private void BtnSignupClick(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }

    void TryCreateUser()
    {
        if (tbx_Firstname.Text == "")
        {
            string email = tbx_Email.Text;
            string password = tbx_Password.Text.ToSHA256();
            User user = new User(email, password);
            user.ToString();
            DatabaseHelper helper = new DatabaseHelper("");
            helper.ExecuteNonQuery();
        }
        Address address = new Address()
        {
            Country = tbx_City.Text,
            City = tbx_City.Text,
            ZippCode = int.Parse(tbx_ZippCode.Text),
            Street = tbx_Street.Text,
            HouseNumber = int.Parse(tbx_HouseNr.Text),
            ApartmentNumber = int.Parse(tbx_ApartmentNr.Text)
        };
    }
}
public static class StringExtensions
{
    public static string ToSHA256(this string input)
    {
        // generated
        SHA256 sha = SHA256Managed.Create();
        byte[] bytes = Encoding.UTF8.GetBytes(input);
        byte[] hash = sha.ComputeHash(bytes);

        StringBuilder output = new StringBuilder(hash.Length * 2);
        foreach (byte b in hash)
            output.AppendFormat("{0:x2}", b); // Convert each byte to a string and append to the formatter

        return output.ToString();
    }
}