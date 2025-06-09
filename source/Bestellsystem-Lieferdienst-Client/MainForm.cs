using Bestellsystem_Lieferdienst.PL;
using Bestellsystem_Lieferdienst_Client;

namespace Bestellsystem_Lieferdienst
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeManualComponent();
        }

        public static void ShowError(string error)
        {
            Program.form.Controls.Add(new ErrorPopup(error));
        }
    }
}
