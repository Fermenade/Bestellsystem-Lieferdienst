using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.Server;
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
    private async void BtnSignupClick(object sender, EventArgs e)
    {
        User user;
        try
        {
            user = ExtendedUser.CreateUser(tbx_Email.Text, tbx_Password.Text);
        }
        catch (Exception ex)
        {
            if (ex.Message == "DATABASE KEY EXISTS")
            {
                lb_Error.Text = "Der User exestiert bereits, verwende eine andere Email.";
            }
            lb_Error.Text = ex.Message;
            return;
        }
        if (checkBox1.Checked)
        {
            try
            {
                user.Address = Address.CreateAddress(tbx_Country.Text, tbx_ZippCode.Text, tbx_City.Text,
                tbx_Street.Text, tbx_HouseNr.Text, tbx_ApartmentNr.Text);
            }
            catch (Exception ex)
            {
                lb_Error.Text = ex.Message;
                return;
            }
        }
        else
        {
            lb_Error.Text =
                @"Bestätigen sie, dass sie keine Adresse Ihrem Account hinterlegen wollen. (Sie können dies in ihrem Account Details jederzeit nachholen)";
            btn_Signup.Text = @"Erstellen ohne Adresse.";

            if (btn_Signup.Text != @"Erstellen ohne Adresse.")
                return;
        }
        try
        {
            lb_Error.Text = "Am einloggen...";
            Client.client.User = await ServerData.SetUser(user);
            this.LoadView(new StartForm());
        }
        catch (Exception ex)
        {
            lb_Error.Text += ex.Message;
        }
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