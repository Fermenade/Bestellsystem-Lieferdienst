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
            btn_Login.Location = new Point(508, 4);
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
            btn_Register.Location = new Point(422, 4);
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
            pBXProduct2.Location = new Point(387, 88);
            pBXProduct2.Name = "pBXProduct2";
            pBXProduct2.Size = new Size(124, 132);
            pBXProduct2.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXProduct2.TabIndex = 8;
            pBXProduct2.TabStop = false;
            // 
            // lbxProduct2Name
            // 
            lbxProduct2Name.AutoSize = true;
            lbxProduct2Name.Location = new Point(387, 223);
            lbxProduct2Name.Name = "lbxProduct2Name";
            lbxProduct2Name.Size = new Size(39, 15);
            lbxProduct2Name.TabIndex = 9;
            lbxProduct2Name.Text = "Döner";
            lbxProduct2Name.Click += lblProduct1Name_Click;
            // 
            // lbxProduct2Price
            // 
            lbxProduct2Price.AutoSize = true;
            lbxProduct2Price.Location = new Point(387, 238);
            lbxProduct2Price.Name = "lbxProduct2Price";
            lbxProduct2Price.Size = new Size(40, 15);
            lbxProduct2Price.TabIndex = 10;
            lbxProduct2Price.Text = "8 Euro";
            lbxProduct2Price.Click += label1_Click;
            // 
            // btnProduct2AddToCart
            // 
            btnProduct2AddToCart.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct2AddToCart.Location = new Point(432, 223);
            btnProduct2AddToCart.Name = "btnProduct2AddToCart";
            btnProduct2AddToCart.Size = new Size(79, 27);
            btnProduct2AddToCart.TabIndex = 11;
            btnProduct2AddToCart.Text = "Warenkorb";
            btnProduct2AddToCart.UseVisualStyleBackColor = true;
            // 
            // cbxCategory
            // 
            cbxCategory.FormattingEnabled = true;
            cbxCategory.Location = new Point(107, 62);
            cbxCategory.Name = "cbxCategory";
            cbxCategory.Size = new Size(121, 23);
            cbxCategory.TabIndex = 12;
            // 
            // lbxCategory
            // 
            lbxCategory.AutoSize = true;
            lbxCategory.Location = new Point(107, 44);
            lbxCategory.Name = "lbxCategory";
            lbxCategory.Size = new Size(57, 15);
            lbxCategory.TabIndex = 13;
            lbxCategory.Text = "Kategorie";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 24);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 14;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbxSearch
            // 
            lbxSearch.AutoSize = true;
            lbxSearch.Location = new Point(114, 4);
            lbxSearch.Name = "lbxSearch";
            lbxSearch.Size = new Size(39, 15);
            lbxSearch.TabIndex = 15;
            lbxSearch.Text = "Suche";
            // 
            // btnProduct1AddToCart
            // 
            btnProduct1AddToCart.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct1AddToCart.Location = new Point(277, 223);
            btnProduct1AddToCart.Name = "btnProduct1AddToCart";
            btnProduct1AddToCart.Size = new Size(79, 27);
            btnProduct1AddToCart.TabIndex = 19;
            btnProduct1AddToCart.Text = "Warenkorb";
            btnProduct1AddToCart.UseVisualStyleBackColor = true;
            // 
            // lbxProduct1Price
            // 
            lbxProduct1Price.AutoSize = true;
            lbxProduct1Price.Location = new Point(232, 238);
            lbxProduct1Price.Name = "lbxProduct1Price";
            lbxProduct1Price.Size = new Size(46, 15);
            lbxProduct1Price.TabIndex = 18;
            lbxProduct1Price.Text = "11 Euro";
            // 
            // lbxProduct1Name
            // 
            lbxProduct1Name.AutoSize = true;
            lbxProduct1Name.Location = new Point(232, 223);
            lbxProduct1Name.Name = "lbxProduct1Name";
            lbxProduct1Name.Size = new Size(44, 15);
            lbxProduct1Name.TabIndex = 17;
            lbxProduct1Name.Text = "Dürüm";
            // 
            // pBXProduct1
            // 
            pBXProduct1.Image = Bestellsystem_Lieferdienst.Properties.Resources.dueruem;
            pBXProduct1.Location = new Point(232, 88);
            pBXProduct1.Name = "pBXProduct1";
            pBXProduct1.Size = new Size(124, 132);
            pBXProduct1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXProduct1.TabIndex = 16;
            pBXProduct1.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 533);
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
            Margin = new Padding(1);
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
            ResumeLayout(false);

            cbxCategory.Items.Add("Alle");
            cbxCategory.SelectedIndex = 0;
            foreach (var VARIABLE in GetData.GetAllProductCategories())
            {
                cbxCategory.Items.Add(VARIABLE);
            }
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
