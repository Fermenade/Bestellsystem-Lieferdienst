using Bestellsystem_Lieferdienst_Client.BL.ShopingCart;
using System.ComponentModel;

namespace Bestellsystem_Lieferdienst_Client.PL.ShopingCart_Controls
{
    //Generated
    public partial class ShoppingCart : FlowLayoutPanel
    {
        public readonly Dictionary<CartItem, ShoppingCartItemControl> itemControlMap = new();
        public ShoppingCart()
        {
            InitializeComponent();

            // Setup initial render
            LoadManualControls();
            RenderCartItems();

            // Update on item add/remove
            CartManager.CartItems.ListChanged += RenderCartItems;
        }

        void LoadManualControls()
        {
            Controls.Add(headerPanel);
        }

        private void RenderCartItems(object? o = null, ListChangedEventArgs? e = null)
        {
            // We track changes efficiently without clearing everything.

            // Remove items
            //If ()

            foreach (var control in itemControlMap.Values.ToList())
            {
                var cartItem = control.CartItem;
                if (!CartManager.CartItems.Contains(cartItem))
                {

                    Controls.Remove(itemControlMap[cartItem]);
                    itemControlMap.Remove(cartItem);
                    return;
                }
            }

            // Add/Update controls for added cart items.
            foreach (var item in CartManager.CartItems)
            {
                // Add new items
                if (!itemControlMap.ContainsKey(item))
                {
                    var control = new ShoppingCartItemControl();
                    control.SetCartItem(item);
                    control.IncreaseClicked += (s, e) => { item.Quantity++; };

                    control.DecreaseClicked += (s, e) =>
                    {
                        if (item.Quantity == 1)
                        {
                            CartManager.RemoveProduct(item.Product);
                        }
                        item.Quantity--;
                    };

                    control.RemoveClicked += (s, e) => { CartManager.RemoveProduct(item.Product); };

                    control.Margin = new Padding(5);
                    Controls.Add(control);

                    itemControlMap[item] = control; // Keep track of this control.
                }
                // Update Items
                else
                {
                    // Update existing control (e.g., quantity change).
                    itemControlMap[item].SetCartItem(item);
                }
            }
        }
    }
}