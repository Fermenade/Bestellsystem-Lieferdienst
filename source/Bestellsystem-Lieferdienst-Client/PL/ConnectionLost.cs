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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Client.client.ConnectToServer(textBox2.Text, (int)numericUpDown1.Value);
            }
            catch (Exception ex)
            {
                label4.Text = ex.Message;
            }

            Task.Run((() =>
            {
                while (!Client.client.Connected || !Client.client.InitializeFinished)
                {

                }
            }));
            this.LoadView(new StartForm());
        }
    }
}
