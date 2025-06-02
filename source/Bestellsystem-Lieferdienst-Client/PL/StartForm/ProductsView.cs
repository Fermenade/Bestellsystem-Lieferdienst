using System.Data.Common;
using Bestellsystem_Lieferdienst.BL;
using Bestellsystem_Lieferdienst_Client;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.PL.StartForm
{
    public partial class ProductsView : FlowLayoutPanel
    {
        public ProductsView()
        {
            InitializeComponent();
        }

        private List<Product> allItems = new();

        public void SetItems(IEnumerable<Product> items)
        {
            allItems = items.ToList();
        }

        public void ApplyFilter(string nameFilter, string categoryFilter)
        {
            Controls.Clear();

            var filtered = allItems
                .Where(name =>
                    (
                        name.Name.Contains(nameFilter, StringComparison.OrdinalIgnoreCase) ||
                        name.Description.Contains(nameFilter, StringComparison.OrdinalIgnoreCase)
                    )
                    && 
                    (
                        name.Categories.Contains(categoryFilter) ||
                        "Alle" == categoryFilter
                        )
                    );

            foreach (var name in filtered)
            {
                var control = new ProductEntry(name);
                control.Click += (o, e) =>
                {
                    Program.form.LoadView(new ProductDetailView(name));

                };
                Controls.Add(control);
            }
        }
    }
}
