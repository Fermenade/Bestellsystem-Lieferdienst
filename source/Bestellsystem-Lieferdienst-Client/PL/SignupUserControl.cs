using System.Security.Cryptography;
using System.Text;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL;

public partial class SignupUserControl : UserControl
{
    public SignupUserControl()
    {
        InitializeComponent();
        //InitializeManualComponent();
    }

    private void BtnSignupClick(object sender, EventArgs e)
    {
        TryCreateUser();
    }

    void TryCreateUser()
    {
        User user;
        try
        {
            if (tbx_Firstname.Text == "")
            {
                string email = tbx_Email.Text,
                    password = tbx_Password.Text.ToSHA256();
                user = new User(email, password);
            }
            else
            {
                string firstname = tbx_Firstname.Text,
                    lastname = tbx_Lastname.Text,
                    email = tbx_Email.Text,
                    password = tbx_Password.Text;

                user = new User(firstname, lastname, email, password);
            }
        }
        catch (Exception ex)
        {
            lb_Error.Text = ex.Message;
        }

        string country = tbx_City.Text,
            city = tbx_City.Text,
            street = tbx_Street.Text;
        //Cuz every number normally starts at 1
        int zippCode = 0,
            houseNumber = 0,
            apartmentNumber = 0;
        try
        {
            zippCode = int.Parse(tbx_ZippCode.Text);
            houseNumber = int.Parse(tbx_HouseNr.Text);
            apartmentNumber = int.Parse(tbx_ApartmentNr.Text);

            Address address;
            if (tbx_ApartmentNr.Text == "")
            {

                address = new Address(country, zippCode, city, street, houseNumber);
            }
            else
            {
                address = new Address(country, zippCode, city, street, houseNumber, apartmentNumber);
            }
        }
        catch (Exception e)
        {
            lb_Error.Text = $"{e.Message}. \n Bestätigen sie, dass sie keine Adresse Ihrem Account hinterlegen wollen. (Sie können dies in ihrem Account Details jederzeit nachholen)";
            btn_Signup.Text = "Erstellen ohne Adresse.";
        }
    }

    private void lb_Error_Click(object sender, EventArgs e)
    {

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