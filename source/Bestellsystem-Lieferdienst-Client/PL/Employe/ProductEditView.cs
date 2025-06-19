using Bestellsystem_Lieferdienst_Client.BL;
using Client_Server_Code_Library;

namespace Bestellsystem_Lieferdienst_Client.PL.Employe
{
    public partial class ProductEditView : UserControl
    {
        private Product Product;
        public ProductEditView(Product product)
        {
            InitializeComponent();
            Product = product;
            InitializeManualComponent();
        }

        async void InitializeManualComponent()
        {
            tbx_Name.Text = Product.Name;
            tbx_Description.Text = Product.Description;
            tbx_Price.Text = Product.Price.ToString();
            if (Product.Picture != null)
            {
                using MemoryStream ms = new MemoryStream(Product.Picture);
                // Create an image from the byte array
                pictureBox1.Image = Image.FromStream(ms);
            }
            else
            {
                pictureBox1.Image = Image.FromFile("../../../Resources/fallbackIMG.png");
            }

            foreach (ProductCategory VARIABLE in Product.Categories ?? [])
            {
                listBox1.Items.Add(VARIABLE);
            }
            foreach (ProductCategory VARIABLE in await ServerData.GetAllProductCategories() ?? [])
            {
                listBox2.Items.Add(VARIABLE);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Product.ProductId != null)
            {
                // now this is a bit dirty to use the tbx and then the Product again, but this is ez., it's 4 am and I dont have any more time left to waste.
                ServerData.UpdateProduct(Product.CreateProduct((int)Product.ProductId, tbx_Name.Text, tbx_Description.Text, tbx_Price.Text,
                    Product.Picture ?? throw new Exception("Picture was null"), listBox1.Items.Cast<string>().ToArray()));
            }
            else
            {
                Product product;
                try
                {
                    product =
                        Product.CreateProduct(tbx_Name.Text, tbx_Description.Text, tbx_Price.Text,
                            Product.Picture,
                            listBox1.Items.Cast<ProductCategory>().ToArray());
                }
                catch (Exception exception)
                {
                    label5.Text = exception.Message;
                    return;
                }
                ServerData.SetProduct(product);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Image Files (*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF)|*.BMP;*.JPG;*.JPEG;*.PNG;*.GIF|All files (*.*) | *.* ";
            openFileDialog.Title = "Wähle ein neues bild aus:";
            openFileDialog.Multiselect = false;
            openFileDialog.InitialDirectory = "../../../";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Product.Picture = File.ReadAllBytes(openFileDialog.FileName);

                    using MemoryStream ms = new MemoryStream(Product.Picture);
                    // Create an image from the byte array
                    pictureBox1.Image = Image.FromStream(ms);
                }
                catch (Exception exception)
                {
                    label5.Text = exception.Message;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.LoadView(new ProductsEditOverviewView());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            // Generated
            // Iterate through the selected items in reverse order 
            for (int i = listBox1.SelectedItems.Count - 1; i >= 0; i--)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[i]);
            }
            listBox1.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddCategoriesToProduct(listBox2.SelectedItems.Cast<ProductCategory>());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddCategoryToProduct(new ProductCategory(tbx_NewCategorie.Text));

            tbx_NewCategorie.Text = "";
        }
        private void AddCategoriesToProduct(IEnumerable<ProductCategory> categories)
        {
            IEnumerable<ProductCategory> listboxItems = listBox1.Items.Cast<ProductCategory>();
            foreach (var VARIABLE in categories)
            {
                if (listboxItems.Any(i => i.name == VARIABLE.name)) return;

                listBox1.Items.Add(VARIABLE);
            }
        }
        private void AddCategoryToProduct(ProductCategory category)
        {
            IEnumerable<ProductCategory> listboxItems = listBox1.Items.Cast<ProductCategory>();
            if (listboxItems.Any(i => i.name == category.name)) return;

            listBox1.Items.Add(category);
        }
    }
}
