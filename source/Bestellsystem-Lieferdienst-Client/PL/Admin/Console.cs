using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.Server;

namespace Bestellsystem_Lieferdienst_Client.PL.Admin
{
    public partial class Console : UserControl
    {
        public Console()
        {
            InitializeComponent();
            InitalizeManualComponent();
        }
        private void InitalizeManualComponent()
        {
            // Setup the RichTextBox like a console
            richTextBoxConsole.ReadOnly = true;
            richTextBoxConsole.BackColor = System.Drawing.Color.Black;
            richTextBoxConsole.ForeColor = System.Drawing.Color.White;
            richTextBoxConsole.Font = new System.Drawing.Font("Courier New", 10);

            textBox1.KeyPress += textBox1_KeyPress;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                e.Handled = true;
                string command = textBox1.Text.Trim();
                ProcessCommand(command);
                textBox1.Clear();
            }
        }

        private async void ProcessCommand(string command)
        {
            //show own command
            AppendToConsole(">>> " + command);
            if (command.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                AppendToConsole("Exiting program...");
                Application.Exit(); // Close the application
            }

            string i;
            try
            {
                i = await Client.client.SendAndReturnAsync<string>(command);
            }
            catch (Exception e)
            {
                i = "Error: " + e.Message;
            }

            AppendToConsole(i);
        }

        private void AppendToConsole(string text)
        {
            richTextBoxConsole.AppendText(text + Environment.NewLine);
            richTextBoxConsole.ScrollToCaret(); // Scroll to the bottom
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadView(new StartForm());
        }
    }
}
