using System.Security.Cryptography.X509Certificates;
using Bestellsystem_Lieferdienst.PL;
using Client_Server_Code_Library;
using System.ComponentModel;

namespace Bestellsystem_Lieferdienst_Client.PL;

public class ShoppingCardControl : FlowLayoutPanel
{
    private List<ShoppingCardEntry>? Products { get; set; }

    public ShoppingCardControl()
    {
        Initialize();
    }

    private void Initialize()
    {
        this.Products = new List<ShoppingCardEntry>();
        this.AutoSize = true;
    }

    // Expose a property to bind the data source to
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]

    // Expose a property to bind the data source to
    public List<ShoppingCardEntry>? DataSource
    {
        get { return Products; }
        set
        {
            Products = value;
            UpdateDisplay();
        }
    }

    private void UpdateDisplay()
    {
        // Clear existing controls
        Controls.Clear();

        // Create and add ShoppingCardEntry panels based on the data source
        if (Products != null)
        {
            foreach (var entry in Products)
            {
                Controls.Add(entry);
            }
        }
    }
}