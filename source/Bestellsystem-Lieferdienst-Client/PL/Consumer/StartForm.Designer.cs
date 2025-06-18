using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using Bestellsystem_Lieferdienst_Client.PL;
using Bestellsystem_Lieferdienst_Client.BL;
using Bestellsystem_Lieferdienst_Client.PL.StartForm_Controls;
using Bestellsystem_Lieferdienst_Client.Server;
using Client_Server_Code_Library;
using Bestellsystem_Lieferdienst.PL.Konsument.ShopingCart_Controls;

namespace Bestellsystem_Lieferdienst_Client.PL
{
    partial class StartForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_Login = new Button();
            btn_Register = new Button();
            cbxCategory = new ComboBox();
            lbxCategory = new Label();
            textBox1 = new TextBox();
            lbxSearch = new Label();
            btn_SucheBestätigen = new Button();
            lbl_OurProducts = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(1327, 17);
            btn_Login.Margin = new Padding(1);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(98, 35);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(1186, 17);
            btn_Register.Margin = new Padding(1);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(114, 38);
            btn_Register.TabIndex = 7;
            btn_Register.Text = "Registrieren";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(457, 126);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(121, 33);
            cbxCategory.TabIndex = 12;
            cbxCategory.SelectedIndexChanged += cbxCategory_SelectedIndexChanged;
            // 
            // lbxCategory
            // 
            lbxCategory.AutoSize = true;
            lbxCategory.Location = new Point(457, 98);
            lbxCategory.Name = "lbxCategory";
            lbxCategory.Size = new Size(87, 25);
            lbxCategory.TabIndex = 13;
            lbxCategory.Text = "Kategorie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(457, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 31);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbxSearch
            // 
            lbxSearch.AutoSize = true;
            lbxSearch.Location = new Point(459, 26);
            lbxSearch.Name = "lbxSearch";
            lbxSearch.Size = new Size(59, 25);
            lbxSearch.TabIndex = 15;
            lbxSearch.Text = "Suche";
            // 
            // btn_SucheBestätigen
            // 
            btn_SucheBestätigen.Location = new Point(584, 50);
            btn_SucheBestätigen.Name = "btn_SucheBestätigen";
            btn_SucheBestätigen.Size = new Size(78, 38);
            btn_SucheBestätigen.TabIndex = 16;
            btn_SucheBestätigen.Text = "Suchen";
            btn_SucheBestätigen.UseVisualStyleBackColor = true;
            btn_SucheBestätigen.Click += btn_SucheBestätigen_Click;
            // 
            // lbl_OurProducts
            // 
            lbl_OurProducts.AutoSize = true;
            lbl_OurProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_OurProducts.Location = new Point(597, 86);
            lbl_OurProducts.Name = "lbl_OurProducts";
            lbl_OurProducts.Size = new Size(132, 40);
            lbl_OurProducts.TabIndex = 17;
            lbl_OurProducts.Text = "Produkte";
            // 
            // button1
            // 
            button1.Location = new Point(1186, 55);
            button1.Name = "button1";
            button1.Size = new Size(188, 58);
            button1.TabIndex = 18;
            button1.Text = "Einstellungen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(804, 23);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 19;
            button2.Text = "Mitarbeiter";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // StartForm
            // 
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lbl_OurProducts);
            Controls.Add(btn_SucheBestätigen);
            Controls.Add(lbxSearch);
            Controls.Add(textBox1);
            Controls.Add(lbxCategory);
            Controls.Add(cbxCategory);
            Controls.Add(btn_Register);
            Controls.Add(btn_Login);
            Margin = new Padding(1);
            Name = "StartForm";
            Size = new Size(1452, 849);
            Load += StartForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;

        #endregion
        
        private ComboBox cbxCategory;
        private Label lbxCategory;
        private TextBox textBox1;
        private Label lbxSearch;
        private Button btn_SucheBestätigen;
        private Label lbl_OurProducts;
        private ShoppingCartView shoppingcart = new ShoppingCartView();
        private ProductsView productsView = new ProductsView();


        void InitializeManualComponent()
        {
            if (Client.client.User != null)
            {
                btn_Login.Dispose();
                btn_Register.Dispose();
                button1.Visible = true;
                if (Client.client.User.usertypeID !>= 1)
                {
                    button2.Dispose();
                }
            }
            else
            {
                button1.Dispose();
                button2.Dispose();
            }

            productsView.BackColor = Color.Aquamarine;
            productsView.Dock = DockStyle.Bottom;
            Controls.Add(productsView);
            Controls.Add(shoppingcart);
        }
        private Button button1;
        private Button button2;
    }
}
