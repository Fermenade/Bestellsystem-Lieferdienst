using Bestellsystem_Lieferdienst_Client;
using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.Server;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL
{
    partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void btn_GoToMain_Click(object sender, EventArgs e)
        {
            this.LoadView(new StartForm());
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            User user;
            try
            {
                user = new User(tbx_Mail.Text, tbx_Pass.Text.ToSHA256());
            }
            catch (Exception exception)
            {
                lb_error.Text = exception.Message;
                return;
            }

            lb_error.Text = "Am einloggen...";
            try
            {
                Client.client.User = GetData.GetUser(user).Result;

            }
            catch (System.AggregateException exception)
            {
                lb_error.Text = @"Kein User gefunden mit passenden Daten";
                return;
            }
            this.LoadView(new StartForm());
        }
    }
}
