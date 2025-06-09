namespace Bestellsystem_Lieferdienst.PL
{
    public partial class ErrorPopup : UserControl
    {
        public ErrorPopup(string error)
        {
            InitializeComponent();


            lb_Error.Text = "Server has thrown error: " + error;
        }

        void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
