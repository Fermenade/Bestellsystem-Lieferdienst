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
        try
        {
            ProductManager.AddProducts(items);
        }
        catch (ArgumentException)
        {
            //This is handeled here cuz I think it's not the job of the Manager to handle it.
        }
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
                    name.Categories.All(i => i.name == categoryFilter) ||
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