using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                return;
            }

            InitializeComponent();
            InitializeManuqlComponent();


        }

        void InitializeManuqlComponent()
        {
            tbxEMail.Text = Client.client.User.email.ToString();
            tbxStraße.Text = Client.client.User.Address.Street.ToString();
            tbxHausnummer.Text = Client.client.User.Address.HouseNumber.ToString();
            tbxApartment.Text = Client.client.User.Address.ApartmentNumber.ToString();
            tbxPLZ.Text = Client.client.User.Address.ZippCode.ToString();
            tbxOrt.Text = Client.client.User.Address.City.ToString();
            tbxLand.Text = Client.client.User.Address.Country.ToString();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            // Wenn dieser Button nur das passwort ändern soll dann muss noch die Methode angepasst werden.
            // Falls du dabei hilfe brauchst, schreib mir.
            if (TryCreateUser(tbxEMail.Text,tbxPassword.Text,tbxLand.Text,tbxPLZ.Text,tbxOrt.Text,tbxStraße.Text,tbxHausnummer.Text,tbxApartment.Text, out User user))
            {
                GetData.UpdateUser(user);
            }
        }
    }
}
