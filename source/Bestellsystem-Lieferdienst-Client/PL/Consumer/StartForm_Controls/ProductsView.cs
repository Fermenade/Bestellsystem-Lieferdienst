using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.BL.StartForm;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL.StartForm_Controls;

public partial class ProductsView : FlowLayoutPanel
{
    public ProductsView()
    {
        InitializeComponent();
    }

    public void SetItems(IEnumerable<Product> items)
    {
        ProductManager.AddProducts(items);
    }

    public void ApplyFilter(string nameFilter, string categoryFilter)
    {
        Controls.Clear();

        var filtered = ProductManager.ProductItemsCache
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