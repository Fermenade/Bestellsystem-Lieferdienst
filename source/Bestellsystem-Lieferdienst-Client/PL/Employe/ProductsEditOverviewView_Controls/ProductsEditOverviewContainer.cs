using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.BL.StartForm;
using Client_Server_Code_Library;
using System.ComponentModel;

namespace Bestellsystem_Lieferdienst_Client.PL.Employe.ProductsEditOverviewView_Controls
{
    public partial class ProductsEditOverviewContainer : FlowLayoutPanel
    {
        public ProductsEditOverviewContainer()
        {
            InitializeComponent();
            InitializeManualComponent();
            RenderCartItems();
        }
        void InitializeManualComponent()
        {
            ProductManager.ProductItemsCache.ListChanged += RenderCartItems();
        }
        public readonly Dictionary<Product, ProductsEditOverviewEntryControl> itemControlMap = new();
        async void Delete(object? sender, EventArgs e)
        {
            if (sender is Product product)
            {
                ServerData.DeleteProduct(product);
                ProductManager.Clear();
                Product[] products = await ServerData.GetAllProducts() ?? [];
                ProductManager.AddProducts(products);
            }
            else
            {
                throw new Exception("sender was not of type product");
            }

        }

        void Edit(object? sender, EventArgs e)
        {
            if (sender is Product product)
            {
                this.LoadView(new ProductEditView(product));
            }
            else
            {
                throw new Exception("sender was not of type product");
            }
        }

        void Show(object? sender, EventArgs e)
        {
            if (sender is Product product)
            {
                this.LoadView(new ProductDetailView(product));
            }
        }

        private ListChangedEventHandler RenderCartItems(object? sender = null, EventArgs? e = null)
        {
            // We track changes efficiently without clearing everything.

            foreach (var control in itemControlMap.Values.ToList())
            {
                var cartItem = control.Product;
                if (!ProductManager.ProductItemsCache.Contains(cartItem))
                {

                    Controls.Remove(itemControlMap[cartItem]);
                    itemControlMap.Remove(cartItem);
                    return null;
                }
            }

            // Add/Update controls for added cart items.
            foreach (var item in ProductManager.ProductItemsCache)
            {
                // Add new items
                if (!itemControlMap.ContainsKey(item))
                {
                    AddRenderedItem(item);
                }
                // Update Items
                else
                {
                    // Update existing control (e.g., quantity change).
                    //itemControlMap[item].SetCartItem(item);
                }
            }

            return null;
        }
        void AddRenderedItem(Product product)
        {
            var control = new ProductsEditOverviewEntryControl(product);
            control.btn_Delete.Click += Delete;
            control.btn_Edit.Click += Edit;

            control.btn_Show.Click += Show;

            control.Margin = new Padding(5);
            Controls.Add(control);

            itemControlMap[product] = control; // Keep track of this control.
        }
    }
}