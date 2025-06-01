using Bestellsystem_Lieferdienst.BL.ShopingCart;
using System.ComponentModel;

namespace Bestellsystem_Lieferdienst.PL
{
    //Generated
    public partial class ShoppingCartItemControl : UserControl
    {
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public CartItem CartItem { get; private set; }

        public event EventHandler IncreaseClicked;
        public event EventHandler DecreaseClicked;
        public event EventHandler RemoveClicked;

        public ShoppingCartItemControl()
        {
            InitializeComponent();
        }

        public void SetCartItem(CartItem item)
        {
            if (CartItem != null)
                CartItem.PropertyChanged -= CartItem_PropertyChanged;

            CartItem = item;
            CartItem.PropertyChanged += CartItem_PropertyChanged;

            UpdateDisplay();
        }

        private void CartItem_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (InvokeRequired)
            {
                Invoke(UpdateDisplay);
            }
            else
            {
                UpdateDisplay();
            }
        }

        private void UpdateDisplay()
        {
            lblName.Text = CartItem.Product.Name;
            lblQuantity.Text = $"{CartItem.Quantity}";
            lblTotalPrice.Text = $"{CartItem.TotalPrice:C}";
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            IncreaseClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            DecreaseClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            RemoveClicked?.Invoke(this, EventArgs.Empty);
        }
    }

}
