using Bestellsystem_Lieferdienst_Client.PL.Employe.ProductsEditOverviewView_Controls;

namespace Bestellsystem_Lieferdienst.PL.Employe.ProductsEditOverviewView_Controls
{
    internal class ProductEditOverviewConainerView : Panel
    {
        private const int width = 1000;
        private ProductsEditOverviewContainer productsEditOverviewContainer;
        private Panel panelTop;

        public ProductEditOverviewConainerView()
        {
            InitializeComponent();
            Dock = DockStyle.Bottom;
            Height = 900;
        }

        private void InitializeComponent()
        {
            Dock = DockStyle.Left;
            Width = width;
            // Create FlowLayoutPanel
            productsEditOverviewContainer = new ProductsEditOverviewContainer()
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                BackColor = Color.White,
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
            Controls.Add(productsEditOverviewContainer);
            Controls.Add(panelTop);
        }
    }
}
