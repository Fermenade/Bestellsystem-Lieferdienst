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
            textBox1.Text = Product.Name;
            textBox2.Text = Product.Description;
            textBox3.Text = Product.Price.ToString();
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

            foreach (string VARIABLE in Product.Categories)
            {
                listBox1.Items.Add(VARIABLE);
            }
            foreach (ProductCategory VARIABLE in await ServerData.GetAllProductCategories())
            {
                listBox2.Items.Add(VARIABLE.name);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (Product.ID != null)
            {
                // now this is a bit dirty to use the tbx and then the Product again, but this is ez., it's 4 am and I dont have any more time left to waste.
                ServerData.UpdateProduct(Product.CreateProduct((int)Product.ID, textBox1.Text, textBox2.Text, textBox3.Text,
                    Product.Picture ?? throw new Exception("Picture was null"), listBox1.Items.Cast<string>().ToArray()));
            }
            else
            {
                ServerData.SetProduct(Product.CreateProduct(textBox1.Text, textBox2.Text, textBox3.Text,
                    Product.Picture ?? throw new Exception("Picture was null"), listBox1.Items.Cast<string>().ToArray()));
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
            listBox1.Items.Remove(listBox1.SelectedItems);
            listBox1.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(listBox2.SelectedItems);
        }
    }
}
