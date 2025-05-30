using Client_Server_Code_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bestellsystem_Lieferdienst_Client.PL;

namespace Bestellsystem_Lieferdienst.PL
{
    public partial class ShoppingCardEntry : Panel
    {
        public Product Product { get; }
        private uint ammount;

        public ShoppingCardEntry(Product product)
        {
            InitializeComponent();
            InitializeManualComponent();
            Product = product;
            ammount = 1;
        }

        public void Delete()
        {
            var shoppingCart = (ShoppingCart)this.Parent; // Assuming this is added to a ShoppingCart
            shoppingCart.Products?.Remove(this);
        }

        public void Decrease()
        {
            if (ammount == 0)
            {
                Delete();
                return;
            }
            else
            {
                this.ammount--;
            }
        }

        public void Increase() => this.ammount++;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Increase
            Increase();
        }

        // Implement Decrease functionality (button1_Click)
        private void button1_Click(object sender, EventArgs e)
        {
            Decrease();
        }
    }
}
