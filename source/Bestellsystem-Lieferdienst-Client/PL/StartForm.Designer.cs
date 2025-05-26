using Bestellsystem_Lieferdienst_Client.PL;
using Bestellsystem_Lieferdienst.BL;

namespace Bestellsystem_Lieferdienst_Client
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
            pBXProduct2 = new PictureBox();
            lbxProduct2Name = new Label();
            lbxProduct2Price = new Label();
            btnProduct2AddToCart = new Button();
            cbxCategory = new ComboBox();
            lbxCategory = new Label();
            textBox1 = new TextBox();
            lbxSearch = new Label();
            btn_SucheBestätigen = new Button();
            lbl_OurProducts = new Label();
            ((System.ComponentModel.ISupportInitialize)pBXProduct2).BeginInit();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(832, 24);
            btn_Login.Margin = new Padding(1);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(51, 20);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(746, 24);
            btn_Register.Margin = new Padding(1);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(79, 20);
            btn_Register.TabIndex = 7;
            btn_Register.Text = "Registrieren";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // pBXProduct2
            // 
            pBXProduct2.Image = Bestellsystem_Lieferdienst.Properties.Resources.doener;
            pBXProduct2.Location = new Point(476, 132);
            pBXProduct2.Name = "pBXProduct2";
            pBXProduct2.Size = new Size(124, 132);
            pBXProduct2.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXProduct2.TabIndex = 8;
            pBXProduct2.TabStop = false;
            // 
            // lbxProduct2Name
            // 
            lbxProduct2Name.AutoSize = true;
            lbxProduct2Name.Location = new Point(476, 267);
            lbxProduct2Name.Name = "lbxProduct2Name";
            lbxProduct2Name.Size = new Size(39, 15);
            lbxProduct2Name.TabIndex = 9;
            lbxProduct2Name.Text = "Döner";
            lbxProduct2Name.Click += lblProduct1Name_Click;
            // 
            // lbxProduct2Price
            // 
            lbxProduct2Price.AutoSize = true;
            lbxProduct2Price.Location = new Point(476, 282);
            lbxProduct2Price.Name = "lbxProduct2Price";
            lbxProduct2Price.Size = new Size(40, 15);
            lbxProduct2Price.TabIndex = 10;
            lbxProduct2Price.Text = "8 Euro";
            lbxProduct2Price.Click += label1_Click;
            // 
            // btnProduct2AddToCart
            // 
            btnProduct2AddToCart.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct2AddToCart.Location = new Point(521, 267);
            btnProduct2AddToCart.Name = "btnProduct2AddToCart";
            btnProduct2AddToCart.Size = new Size(79, 27);
            btnProduct2AddToCart.TabIndex = 11;
            btnProduct2AddToCart.Text = "Warenkorb";
            btnProduct2AddToCart.UseVisualStyleBackColor = true;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(264, 182);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(121, 23);
            cbxCategory.TabIndex = 12;
            // 
            // lbxCategory
            // 
            lbxCategory.AutoSize = true;
            lbxCategory.Location = new Point(263, 164);
            lbxCategory.Name = "lbxCategory";
            lbxCategory.Size = new Size(57, 15);
            lbxCategory.TabIndex = 13;
            lbxCategory.Text = "Kategorie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(264, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbxSearch
            // 
            lbxSearch.AutoSize = true;
            lbxSearch.Location = new Point(264, 66);
            lbxSearch.Name = "lbxSearch";
            lbxSearch.Size = new Size(39, 15);
            lbxSearch.TabIndex = 15;
            lbxSearch.Text = "Suche";
            // 
            // btn_SucheBestätigen
            // 
            btn_SucheBestätigen.Location = new Point(264, 112);
            btn_SucheBestätigen.Name = "btn_SucheBestätigen";
            btn_SucheBestätigen.Size = new Size(75, 23);
            btn_SucheBestätigen.TabIndex = 16;
            btn_SucheBestätigen.Text = "Suchen";
            btn_SucheBestätigen.UseVisualStyleBackColor = true;
            // 
            // lbl_OurProducts
            // 
            lbl_OurProducts.AutoSize = true;
            lbl_OurProducts.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_OurProducts.Location = new Point(469, 86);
            lbl_OurProducts.Name = "lbl_OurProducts";
            lbl_OurProducts.Size = new Size(88, 25);
            lbl_OurProducts.TabIndex = 17;
            lbl_OurProducts.Text = "Produkte";
            // 
            // StartForm
            // 
            Controls.Add(lbl_OurProducts);
            Controls.Add(btn_SucheBestätigen);
            Controls.Add(lbxSearch);
            Controls.Add(textBox1);
            Controls.Add(lbxCategory);
            Controls.Add(cbxCategory);
            Controls.Add(btnProduct2AddToCart);
            Controls.Add(lbxProduct2Price);
            Controls.Add(lbxProduct2Name);
            Controls.Add(pBXProduct2);
            Controls.Add(btn_Register);
            Controls.Add(btn_Login);
            Margin = new Padding(1);
            Name = "StartForm";
            Size = new Size(932, 604);
            Load += StartForm_Load;
            ((System.ComponentModel.ISupportInitialize)pBXProduct2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;

        #endregion

        public void InitializeManualComponent()
        {
            //Disable resizablility

            cbxCategory.Items.Add("Alle");
            cbxCategory.SelectedIndex = 0;
            //foreach (var VARIABLE in GetData.GetAllProductCategories())
            //{
            //    cbxCategory.Items.Add(VARIABLE);
            //}
        }
        private PictureBox pBXProduct2;
        private Label lbxProduct2Name;
        private Label lbxProduct2Price;
        private Button btnProduct2AddToCart;
        private ComboBox cbxCategory;
        private Label lbxCategory;
        private TextBox textBox1;
        private Label lbxSearch;
        private Button btn_SucheBestätigen;
        private Label lbl_OurProducts;
    }
}
