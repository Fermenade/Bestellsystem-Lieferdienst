using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.BL.ShopingCart;
using System.ComponentModel;

namespace Bestellsystem_Lieferdienst_Client.PL
{
    public partial class CheckoutForm : UserControl
    {
        private ListChangedEventHandler listChangedHandler;
        public CheckoutForm()
        {
            InitializeComponent();
            InitializeManualComponent();
        }

        void InitializeManualComponent()
        {
            CartManager.CartItems.ListChanged += listChangedHandler = (s, e) =>
            {
                if (CartManager.CartItems.Count == 0)
                {
                    btn_KaufAbschließen.Enabled = false;
                }
            };

            Controls.Add(shoppingCart);
        }


        private void tbx_PLZ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_KaufAbschließen_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadView(new StartForm());
        }
    }
}
