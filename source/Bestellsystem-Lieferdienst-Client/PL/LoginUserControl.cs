using System.CodeDom;
using Bestellsystem_Lieferdienst.BL;
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
                user = new User(tbx_Mail.Text, tbx_Pass.Text);
            }
            catch (Exception exception)
            {
                lb_error.Text = exception.Message;
                return;
            }
            GetData.GetUser(user);
        }
    }
}
