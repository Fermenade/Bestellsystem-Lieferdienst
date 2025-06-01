namespace Bestellsystem_Lieferdienst.PL
{
    using Bestellsystem_Lieferdienst.BL.ShopingCart;
    //Generated
    using System.Windows.Forms;

    public partial class ShoppingCartView : FlowLayoutPanel
    {
        private readonly Dictionary<CartItem, ShoppingCartItemControl> itemControlMap = new();
        public ShoppingCartView()
        {
            InitializeComponent();

            // Setup initial render
            LoadManualControls();
            RenderCartItems();

            // Update on item add/remove
            CartManager.CartItems.ListChanged += (s, e) => RenderCartItems();
        }

        void LoadManualControls()
        {
            Controls.Add(headerPanel);
        }

        private void RenderCartItems()
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
        //private void RenderCartItems()
            //{
            //    //TODO: this gets called very very often, fix me!
            //    Controls.Clear();
            //    LoadManualControls();
            //    foreach (var item in CartManager.CartItems)
            //    {
            //        var control = new ShoppingCartItemControl();
            //        control.SetCartItem(item);

            //        control.IncreaseClicked += (s, e) =>
            //        {
            //            item.Quantity++;
            //        };

            //        control.DecreaseClicked += (s, e) =>
            //        {
            //            item.Quantity--;
            //            if (item.Quantity <= 0)
            //                CartManager.RemoveProduct(item.Product);
            //        };

            //        control.RemoveClicked += (s, e) =>
            //        {
            //            CartManager.RemoveProduct(item.Product);
            //        };

            //        control.Margin = new Padding(5);
            //        Controls.Add(control);
            //    }
            //}
        }
}