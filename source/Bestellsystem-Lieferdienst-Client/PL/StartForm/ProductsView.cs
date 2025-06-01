using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst.PL.StartForm
{
    public partial class ProductsView : FlowLayoutPanel
    {
        public ProductsView()
        {
            InitializeComponent();
        }

        private List<Product> allItems = new List<Product>();

        public void SetItems(IEnumerable<Product> items)
        {
            allItems = items.ToList();
            ApplyFilter(string.Empty, string.Empty);
        }

        public void ApplyFilter(string nameFilter, string categorieFilter)
        {
            Controls.Clear();
            if (categorieFilter == "Alle") categorieFilter = "";

            var filtered = allItems
                .Where(name =>
                    name.Name.Contains(nameFilter, StringComparison.OrdinalIgnoreCase)|| 
                    name.Description.Contains(nameFilter,StringComparison.OrdinalIgnoreCase) && 
                    name.Categories.Contains(categorieFilter)
                    );

            foreach (var name in filtered)
            {
                var control = new ProductEntry(name);
                Controls.Add(control);
            }
        }
    }
}
