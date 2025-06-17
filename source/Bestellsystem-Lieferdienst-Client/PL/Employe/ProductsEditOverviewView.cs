using Bestellsystem_Lieferdienst_Client.BL;
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

        private void btn_ReturnToStart_Click(object sender, EventArgs e)
        {
            this.LoadView(new StartForm());
        }

        private void btn_newProduct_Click(object sender, EventArgs e)
        {
            this.LoadView(new ProductEditView(new(null, null, 0, null, null)));
        }
    }
}
