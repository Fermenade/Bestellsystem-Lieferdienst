using Bestellsystem_Lieferdienst.BL;

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
    }
}
