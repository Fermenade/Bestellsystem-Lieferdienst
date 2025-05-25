using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bestellsystem_Lieferdienst_Client;
using Bestellsystem_Lieferdienst.Server;
using Bestellsystem_Lieferdienst_Client.PL;

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
            catch(Exception ex)
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
