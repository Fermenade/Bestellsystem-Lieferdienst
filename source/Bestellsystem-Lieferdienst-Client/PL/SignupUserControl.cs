using Bestellsystem_Lieferdienst_Client.BL;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL;

public partial class SignupUserControl : UserControl
{
    public SignupUserControl()
    {
        InitializeComponent();
        InitializeManualComponent();
    }

    void InitializeManualComponent()
    {
        checkBox1_CheckedChanged(checkBox1, EventArgs.Empty);
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
        user = null;
        try
        {
            string email = tbx_Email.Text,
                password = tbx_Password.Text.ToSHA256();
            user = new User(email, password);
        }
        catch (Exception ex)
        {
            lb_Error.Text = $"{ex.Message}";
            return false;
        }

        if (checkBox1.Checked)
        {
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
                if (tbx_ApartmentNr.Text != "")
                    apartmentNumber = int.Parse(tbx_ApartmentNr.Text);
            }
            catch (Exception ex)
            {
                lb_Error.Text = $"{ex.Message}";
                return false;
            }

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
        else
        {
            lb_Error.Text =
                @"Bestätigen sie, dass sie keine Adresse Ihrem Account hinterlegen wollen. (Sie können dies in ihrem Account Details jederzeit nachholen)";
            if (btn_Signup.Text == @"Erstellen ohne Adresse.")
                return true;

            btn_Signup.Text = @"Erstellen ohne Adresse.";
            return false;
        }
        return true;
    }

    private void btn_BackToMain_Click(object sender, EventArgs e)
    {
        this.LoadView(new StartForm());
    }

    private void checkBox1_CheckedChanged(object sender, EventArgs e)
    {
        if (sender is CheckBox checkBox)
        {
            lb_Country.Visible = checkBox.Checked;
            lb_ZippCode.Visible = checkBox.Checked;
            lb_City.Visible = checkBox.Checked;
            lb_Street.Visible = checkBox.Checked;
            lb_HouseNr.Visible = checkBox.Checked;
            lb_ApartmentNr.Visible = checkBox.Checked;

            tbx_Country.Visible = checkBox.Checked;
            tbx_ZippCode.Visible = checkBox.Checked;
            tbx_City.Visible = checkBox.Checked;
            tbx_Street.Visible = checkBox.Checked;
            tbx_HouseNr.Visible = checkBox.Checked;
            tbx_ApartmentNr.Visible = checkBox.Checked;
        }
    }
}