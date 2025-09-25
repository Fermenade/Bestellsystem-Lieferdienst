using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.PL;
using Bestellsystem_Lieferdienst_Client.Server;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.PL
{
    public partial class UserDetailView : UserControl
    {
        public UserDetailView()
        {
            if (Client.client.User == null)
            {
                MessageBox.Show("Sie sind nicht eingeloggt!");
                this.LoadView(new StartForm());
                return;
            }

            InitializeComponent();
            InitializeManuqlComponent();


        }

        void InitializeManuqlComponent()
        {
            tbxEMail.Text = Client.client.User.Email;
            if (Client.client.User.Address != null)
            {
                tbxStraße.Text = Client.client.User.Address.Street.ToString();
                tbxHausnummer.Text = Client.client.User.Address.HouseNr.ToString();
                tbxApartment.Text = Client.client.User.Address.ApartmentNr.ToString();
                tbxPLZ.Text = Client.client.User.Address.PostZip.ToString();
                tbxOrt.Text = Client.client.User.Address.City.ToString();
                tbxLand.Text = Client.client.User.Address.Country.ToString();
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Wenn dieser Button nur das passwort ändern soll dann muss noch die Methode angepasst werden.
            // Falls du dabei hilfe brauchst, schreib mir.
            // Fertige am besten noch ein label an, dass jegliche fehler des users anzeigt. (Wie bereits in der registrierungsform gemacht)
            User user;
            try
            {
                user = ExtendedUser.CreateUser(tbxEMail.Text, tbxPassword.Text);
            }
            catch (Exception exception)
            {
                lb_error.Text = exception.Message;
                return;
            }
            ServerData.UpdateUser(user);
        }

        private void btn_ChangeAddress_Click(object sender, EventArgs e)
        {
            // Wenn der User keine Adresse beim ändern angegeben hat. oder seine Adresse entfernt hat wie willst du das überprüfen?
            try
            {
                Address address = Address.CreateAddress(tbxLand.Text, tbxPLZ.Text, tbxOrt.Text, tbxStraße.Text, tbxHausnummer.Text,
                    tbxApartment.Text);
                // dieser block soll nur ausgeführt werden, wenn der user etwas angegeben hat. Ansonsten soll er die Benutzer Adresse auf null setzten.
                Client.client.User.Address = address;
                ServerData.UpdateUser(Client.client.User!);
            }
            catch (Exception exception)
            {
                lb_error.Text = exception.Message;
                return;
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            this.LoadView(new StartForm());
        }
    }
}
