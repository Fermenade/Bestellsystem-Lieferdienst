namespace Bestellsystem_Lieferdienst_Client.PL.StartForm_Controls
{
    partial class ProductEntry
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            pBXProduct2 = new PictureBox();
            lbxProduct2Name = new Label();
            lbxProduct2Price = new Label();
            btnProduct2AddToCart = new Button();
            ((System.ComponentModel.ISupportInitialize)pBXProduct2).BeginInit();
            SuspendLayout();
            // 
            // pBXProduct2
            // 
            pBXProduct2.Location = new Point(0, 0);
            pBXProduct2.Name = "pBXProduct2";
            pBXProduct2.Size = new Size(182, 195);
            pBXProduct2.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXProduct2.TabIndex = 8;
            pBXProduct2.TabStop = false;
            // 
            // lbxProduct2Name
            // 
            lbxProduct2Name.AutoSize = true;
            lbxProduct2Name.Location = new Point(5, 204);
            lbxProduct2Name.Name = "lbxProduct2Name";
            lbxProduct2Name.Size = new Size(61, 25);
            lbxProduct2Name.TabIndex = 9;
            lbxProduct2Name.Text = "Döner";
            // 
            // lbxProduct2Price
            // 
            lbxProduct2Price.AutoSize = true;
            lbxProduct2Price.Location = new Point(3, 229);
            lbxProduct2Price.Name = "lbxProduct2Price";
            lbxProduct2Price.Size = new Size(66, 25);
            lbxProduct2Price.TabIndex = 10;
            lbxProduct2Price.Text = "99,99€";
            // 
            // btnProduct2AddToCart
            // 
            btnProduct2AddToCart.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProduct2AddToCart.Location = new Point(72, 218);
            btnProduct2AddToCart.Name = "btnProduct2AddToCart";
            btnProduct2AddToCart.Size = new Size(103, 27);
            btnProduct2AddToCart.TabIndex = 11;
            btnProduct2AddToCart.Text = "Warenkorb";
            btnProduct2AddToCart.UseVisualStyleBackColor = true;
            // 
            // ProductEntry
            // 
            Controls.Add(btnProduct2AddToCart);
            Controls.Add(lbxProduct2Price);
            Controls.Add(lbxProduct2Name);
            Controls.Add(pBXProduct2);
            Name = "ProductEntry";
            Size = new Size(187, 257);
            ((System.ComponentModel.ISupportInitialize)pBXProduct2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBXProduct2;
        private Label lbxProduct2Name;
        private Label lbxProduct2Price;
        private Button btnProduct2AddToCart;
    }
}
