using Bestellsystem_Lieferdienst_Client.PL.Employe.ProductsEditOverviewView_Controls;

namespace Bestellsystem_Lieferdienst_Client.PL.Employe
{
    public partial class ProductsEditOverviewView : UserControl
    {
        public ProductsEditOverviewView()
        {
            InitializeComponent();
            InitializeManualComponent();
        }

        void InitializeManualComponent()
        {
            Controls.Add(new ProductsEditOverviewContainer());
        }
    }
}
