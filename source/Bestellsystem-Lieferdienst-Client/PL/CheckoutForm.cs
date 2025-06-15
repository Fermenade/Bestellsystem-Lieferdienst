using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.BL.ShopingCart;
using System.ComponentModel;
using Bestellsystem_Lieferdienst_Client.Server;
using Client_Server_Code_Library;

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

            if (Client.client.User?.Address is { } e)
            {
                tbxPLZ.Text = e.ZipCode.ToString();
                tbxOrt.Text = e.City;
                tbxStraße.Text = e.Street;
                tbxApartment.Text = e.ApartmentNumber.ToString();
                tbxHausnummer.Text = e.HouseNumber.ToString();
                tbxLand.Text = e.Country;
            }
        }

        private void btn_KaufAbschließen_Click(object sender, EventArgs e)
        {
            Order order;
            try
            {
                order = Order.CreateOrder(Address.CreateAddress(tbxLand.Text, tbxPLZ.Text, tbxOrt.Text, tbxStraße.Text,
                        tbxHausnummer.Text, tbxApartment.Text), CartManager.CartItems.ToArray<OrderItem>(), Client.client.User);
            }
            catch (Exception ex)
            {
                lb_error.Text = ex.Message;
                return;
            }

            ServerData.SetOrder(order);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.LoadView(new StartForm());
        }
    }
}
