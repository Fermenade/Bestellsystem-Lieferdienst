using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.BL.ShopingCart;
using Bestellsystem_Lieferdienst_Client.BL.StartForm;
using Bestellsystem_Lieferdienst_Client.PL.ShopingCart_Controls;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL.Employe.ProductsEditOverviewView_Controls
{
    public partial class ProductsEditOverviewContainer : FlowLayoutPanel
    {
        public readonly Dictionary<Product, ProductsEditOverviewEntryControl> itemControlMap = new();

        public ProductsEditOverviewContainer()
        {
            InitializeComponent();
            InitializeManualComponent();
            RenderCartItems();
        }

        void InitializeManualComponent()
        {
            ProductManager.ProductItemsCache.ListChanged += (s, e) => RenderCartItems();
        }

        private void RenderCartItems()
        {
            // We track changes efficiently without clearing everything.

            //foreach (var control in itemControlMap.Values.ToList())
            //{
            //    var cartItem = control.CartItem;
            //    if (!ProductManager.ProductItemsCache.Contains(cartItem))
            //    {

            //        Controls.Remove(itemControlMap[cartItem]);
            //        itemControlMap.Remove(cartItem);
            //        return;
            //    }
            //}

            //// Add/Update controls for added cart items.
            //foreach (var item in ProductManager.CartItems)
            //{
            //    // Add new items
            //    if (!itemControlMap.ContainsKey(item))
            //    {
            //        var control = new ProductsEditOverviewEntryControl();
            //        control.btn_Delete
            //        control += (s, e) => { item.Quantity++; };

            //        control.DecreaseClicked += (s, e) =>
            //        {
            //            if (item.Quantity == 1)
            //            {
            //                CartManager.RemoveProduct(item.Product);
            //            }
            //            item.Quantity--;
            //        };

            //        control.RemoveClicked += (s, e) => { CartManager.RemoveProduct(item.Product); };

            //        control.Margin = new Padding(5);
            //        Controls.Add(control);

            //        itemControlMap[item] = control; // Keep track of this control.
            //    }
            //    // Update Items
            //    else
            //    {
            //        // Update existing control (e.g., quantity change).
            //        itemControlMap[item].SetCartItem(item);
            //    }
            //}
            void AddRenderedItem(Product product)
            {
                var control = new ProductsEditOverviewEntryControl(product);
                control.btn_Delete.Click += (s, e) =>
                {
                    ServerData.DeleteProduct(product);
                };
                control.btn_Edit.Click += (s, e) =>
                {
                    this.LoadView(new ProductEditView(product));
                };

                control.btn_Show.Click += (s, e) =>
                {
                    this.LoadView(new ProductDetailView(product));
                };

                control.RemoveClicked += (s, e) => { CartManager.RemoveProduct(item.Product); };

                control.Margin = new Padding(5);
                Controls.Add(control);

                itemControlMap[product] = control; // Keep track of this control.
            }
        }
    }
}