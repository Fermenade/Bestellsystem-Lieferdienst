using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.BL.ShopingCart;
using Bestellsystem_Lieferdienst_Client.PL;
using Bestellsystem_Lieferdienst_Client.PL.ShopingCart_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bestellsystem_Lieferdienst.PL.Employe.ProductsEditOverviewView_Controls
{
    internal class ProductEditOverviewConainerView : Panel
    {
        private const int width = 460;
        private ShoppingCart shoppingCart = new();
        private Panel panelTop;
        public Panel panelBottom;

        public ProductEditOverviewConainerView()
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
            Label lblAmount = new Label
                { Text = "Beschreibung", Left = 140, Width = 80, Top = 10, ForeColor = Color.Black };
            Label lblTotal = new Label { Text = "Preis", Left = 260, Width = 60, Top = 10, ForeColor = Color.Black };

            // Create Sticky Top Panel
            panelTop = new Panel
            {
                Height = 50,
                Dock = DockStyle.Top,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.AliceBlue,
            };
            panelTop.Controls.AddRange(new[] { lblTitle, lblAmount, lblTotal });



            // Add to form
            Controls.Add(shoppingCart);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
        }
    }
}
