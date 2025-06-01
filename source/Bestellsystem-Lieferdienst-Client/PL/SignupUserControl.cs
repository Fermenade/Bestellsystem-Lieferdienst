using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst.PL;
using Client_Server_Code_Library;
using System.Security.Cryptography;
using System.Text;

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
        if (TryCreateUser(out User user))
        {
            GetData.SetUser(user);
        }
    }

    bool TryCreateUser(out User user)
    {
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
            user = null;
            return false;
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
            user.Address = address;
        }
        catch (Exception e)
        {
            lb_Error.Text = $"{e.Message}. \n Bestätigen sie, dass sie keine Adresse Ihrem Account hinterlegen wollen. (Sie können dies in ihrem Account Details jederzeit nachholen)";
            if (btn_Signup.Text == "Erstellen ohne Adresse.")
                return true;

            btn_Signup.Text = "Erstellen ohne Adresse.";
            user = null;
            return false;
        }
        return true;
    }

    private void lb_Error_Click(object sender, EventArgs e)
    {

    }

    private void btn_BackToMain_Click(object sender, EventArgs e)
    {
        this.LoadView(new StartForm());
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