namespace Bestellsystem_Lieferdienst.PL
{
    partial class ShoppingCartItemControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCartItemControl));
            lblName = new Label();
            lblQuantity = new Label();
            lblTotalPrice = new Label();
            btnIncrease = new Button();
            btnDecrease = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(24, 15);
            lblName.Name = "lblName";
            lblName.Size = new Size(175, 51);
            lblName.TabIndex = 0;
            lblName.Text = "Ndummy";
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(234, 28);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(32, 25);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "99";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalPrice.Location = new Point(300, 25);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(95, 28);
            lblTotalPrice.TabIndex = 2;
            lblTotalPrice.Text = "100€";
            // 
            // btnIncrease
            // 
            btnIncrease.Location = new Point(263, 25);
            btnIncrease.Name = "btnIncrease";
            btnIncrease.Size = new Size(30, 30);
            btnIncrease.TabIndex = 3;
            btnIncrease.Text = "+";
            btnIncrease.Click += btnIncrease_Click;
            // 
            // btnDecrease
            // 
            btnDecrease.Location = new Point(205, 25);
            btnDecrease.Name = "btnDecrease";
            btnDecrease.Size = new Size(30, 30);
            btnDecrease.TabIndex = 4;
            btnDecrease.Text = "-";
            btnDecrease.Click += btnDecrease_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(386, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += btnRemove_Click;
            // 
            // ShoppingCartItemControl
            // 
            Controls.Add(pictureBox1);
            Controls.Add(lblName);
            Controls.Add(lblQuantity);
            Controls.Add(lblTotalPrice);
            Controls.Add(btnIncrease);
            Controls.Add(btnDecrease);
            Name = "ShoppingCartItemControl";
            Size = new Size(446, 90);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblName;
        private Label lblQuantity;
        private Label lblTotalPrice;
        private Button btnIncrease;
        private Button btnDecrease;
        private PictureBox pictureBox1;
    }
}
