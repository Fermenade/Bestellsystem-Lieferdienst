using Bestellsystem_Lieferdienst.Server;
using Bestellsystem_Lieferdienst_Client;

namespace Bestellsystem_Lieferdienst.PL
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
            label4.Text = "connecting...";
            Client.client.Dispose();
            Client.client = new(textBox2.Text, (int)numericUpDown1.Value);
            Client.client.ConnectToServer();
        }
    }
}
