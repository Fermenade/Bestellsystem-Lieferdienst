using Bestellsystem_Lieferdienst.BL.ShopingCart;
using Bestellsystem_Lieferdienst_Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bestellsystem_Lieferdienst.PL.ShopingCart
{
    internal class ShoppingCartView:Panel
    {
        private const int width = 460;
        private ShoppingCart shoppingCart = new();
        private Panel panelTop;
        public Panel panelBottom;

        public ShoppingCartView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Dock = DockStyle.Left;
            Width = width;
            // Create FlowLayoutPanel
            shoppingCart = new ShoppingCart()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.White

            };
            // Header Labels
            Label lblTitle = new Label { Text = "Name", Left = 10, Width = 120, Top = 10, ForeColor = Color.Black };
            Label lblAmount = new Label { Text = "Menge", Left = 140, Width = 80, Top = 10, ForeColor = Color.Black };
            Label lblTotal = new Label { Text = "Total", Left = 260, Width = 60, Top = 10, ForeColor = Color.Black };

            // Create Sticky Top Panel
            panelTop = new Panel
            {
                Height = 50,
                Dock = DockStyle.Top,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.AliceBlue,
            };
            panelTop.Controls.AddRange(new [] { lblTitle, lblAmount, lblTotal });

            
            
            Label lblTotalTotal = new Label { Text = $"{0:C}", Left = 140, Width = 100, Top = 15, ForeColor = Color.Black };
            CartManager.CartItems.ListChanged += (s, e) =>
            {
                decimal totalsum = 0;
                foreach (var i in CartManager.CartItems)
                {
                    totalsum += i.TotalPrice;
                }
                lblTotalTotal.Text = $"{totalsum:C}";
            };
            Button btn_button = new Button { Text = "Kaufen", Left = 260, Width = 60, Top = 20, ForeColor = Color.Black };
            btn_button.Click += (s, e) =>
            {
                Parent.LoadView(new CheckoutForm());
            };
            // Create Sticky Bottom Panel
            panelBottom = new Panel
            {
                Height = 100,
                Dock = DockStyle.Bottom,
                BackColor = Color.LightGreen
            };
            panelBottom.Controls.AddRange(new Control [] { lblTotalTotal, btn_button});

            // Add to form
            Controls.Add(shoppingCart);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
        }

        private void Btn_button_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
