using Bestellsystem_Lieferdienst_Client.Server;

namespace Bestellsystem_Lieferdienst_Client.PL
{
    public partial class ConnectionLost : UserControl
    {
        public ConnectionLost()
        {
            InitializeComponent();
            InitializeManualComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            Client.client.Dispose();
            Client.client = new(textBox2.Text, (int)numericUpDown1.Value);
            Client.client.ConnectToServer();
        }
    }
}
