using Bestellsystem_Lieferdienst_Client.PL;

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
            btnProduct1AddToCart = new Button();
            lbxProduct1Price = new Label();
            lbxProduct1Name = new Label();
            pBXProduct1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBXProduct2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBXProduct1).BeginInit();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(1234, 11);
            btn_Login.Margin = new Padding(2, 3, 2, 3);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(124, 55);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(1025, 11);
            btn_Register.Margin = new Padding(2, 3, 2, 3);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(192, 55);
            btn_Register.TabIndex = 7;
            btn_Register.Text = "Registrieren";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // pBXProduct2
            // 
            pBXProduct2.Image = Bestellsystem_Lieferdienst.Properties.Resources.doener;
            pBXProduct2.Location = new Point(940, 241);
            pBXProduct2.Margin = new Padding(7, 8, 7, 8);
            pBXProduct2.Name = "pBXProduct2";
            pBXProduct2.Size = new Size(301, 361);
            pBXProduct2.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXProduct2.TabIndex = 8;
            pBXProduct2.TabStop = false;
            // 
            // lbxProduct2Name
            // 
            lbxProduct2Name.AutoSize = true;
            lbxProduct2Name.Location = new Point(940, 610);
            lbxProduct2Name.Margin = new Padding(7, 0, 7, 0);
            lbxProduct2Name.Name = "lbxProduct2Name";
            lbxProduct2Name.Size = new Size(100, 41);
            lbxProduct2Name.TabIndex = 9;
            lbxProduct2Name.Text = "Döner";
            lbxProduct2Name.Click += lblProduct1Name_Click;
            // 
            // lbxProduct2Price
            // 
            lbxProduct2Price.AutoSize = true;
            lbxProduct2Price.Location = new Point(940, 651);
            lbxProduct2Price.Margin = new Padding(7, 0, 7, 0);
            lbxProduct2Price.Name = "lbxProduct2Price";
            lbxProduct2Price.Size = new Size(102, 41);
            lbxProduct2Price.TabIndex = 10;
            lbxProduct2Price.Text = "8 Euro";
            lbxProduct2Price.Click += label1_Click;
            // 
            // btnProduct2AddToCart
            // 
            btnProduct2AddToCart.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct2AddToCart.Location = new Point(1049, 610);
            btnProduct2AddToCart.Margin = new Padding(7, 8, 7, 8);
            btnProduct2AddToCart.Name = "btnProduct2AddToCart";
            btnProduct2AddToCart.Size = new Size(192, 74);
            btnProduct2AddToCart.TabIndex = 11;
            btnProduct2AddToCart.Text = "Warenkorb";
            btnProduct2AddToCart.UseVisualStyleBackColor = true;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(261, 170);
            cbxCategory.Margin = new Padding(7, 8, 7, 8);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(288, 49);
            cbxCategory.TabIndex = 12;
            // 
            // lbxCategory
            // 
            lbxCategory.AutoSize = true;
            lbxCategory.Location = new Point(261, 121);
            lbxCategory.Margin = new Padding(7, 0, 7, 0);
            lbxCategory.Name = "lbxCategory";
            lbxCategory.Size = new Size(145, 41);
            lbxCategory.TabIndex = 13;
            lbxCategory.Text = "Kategorie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(277, 66);
            textBox1.Margin = new Padding(7, 8, 7, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(288, 47);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbxSearch
            // 
            lbxSearch.AutoSize = true;
            lbxSearch.Location = new Point(277, 11);
            lbxSearch.Margin = new Padding(7, 0, 7, 0);
            lbxSearch.Name = "lbxSearch";
            lbxSearch.Size = new Size(98, 41);
            lbxSearch.TabIndex = 15;
            lbxSearch.Text = "Suche";
            // 
            // btnProduct1AddToCart
            // 
            btnProduct1AddToCart.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct1AddToCart.Location = new Point(673, 610);
            btnProduct1AddToCart.Margin = new Padding(7, 8, 7, 8);
            btnProduct1AddToCart.Name = "btnProduct1AddToCart";
            btnProduct1AddToCart.Size = new Size(192, 74);
            btnProduct1AddToCart.TabIndex = 19;
            btnProduct1AddToCart.Text = "Warenkorb";
            btnProduct1AddToCart.UseVisualStyleBackColor = true;
            // 
            // lbxProduct1Price
            // 
            lbxProduct1Price.AutoSize = true;
            lbxProduct1Price.Location = new Point(563, 651);
            lbxProduct1Price.Margin = new Padding(7, 0, 7, 0);
            lbxProduct1Price.Name = "lbxProduct1Price";
            lbxProduct1Price.Size = new Size(118, 41);
            lbxProduct1Price.TabIndex = 18;
            lbxProduct1Price.Text = "11 Euro";
            // 
            // lbxProduct1Name
            // 
            lbxProduct1Name.AutoSize = true;
            lbxProduct1Name.Location = new Point(563, 610);
            lbxProduct1Name.Margin = new Padding(7, 0, 7, 0);
            lbxProduct1Name.Name = "lbxProduct1Name";
            lbxProduct1Name.Size = new Size(109, 41);
            lbxProduct1Name.TabIndex = 17;
            lbxProduct1Name.Text = "Dürüm";
            // 
            // pBXProduct1
            // 
            pBXProduct1.Image = Bestellsystem_Lieferdienst.Properties.Resources.dueruem;
            pBXProduct1.Location = new Point(563, 241);
            pBXProduct1.Margin = new Padding(7, 8, 7, 8);
            pBXProduct1.Name = "pBXProduct1";
            pBXProduct1.Size = new Size(301, 361);
            pBXProduct1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXProduct1.TabIndex = 16;
            pBXProduct1.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 722);
            Controls.Add(btnProduct1AddToCart);
            Controls.Add(lbxProduct1Price);
            Controls.Add(lbxProduct1Name);
            Controls.Add(pBXProduct1);
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
            Margin = new Padding(2, 3, 2, 3);
            Name = "StartForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pBXProduct2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBXProduct1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;

        #endregion

        public void InitializeManualComponent()
        {
            //Disable resizablility
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ShoppingCart e = new ShoppingCart();
            ResumeLayout(false);
        }
        private PictureBox pBXProduct2;
        private Label lbxProduct2Name;
        private Label lbxProduct2Price;
        private Button btnProduct2AddToCart;
        private ComboBox cbxCategory;
        private Label lbxCategory;
        private TextBox textBox1;
        private Label lbxSearch;
        private Button btnProduct1AddToCart;
        private Label lbxProduct1Price;
        private Label lbxProduct1Name;
        private PictureBox pBXProduct1;
    }
}
