namespace Bestellsystem_Lieferdienst.PL
{
    partial class produktansicht
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
            pBXMainProductPic = new PictureBox();
            lbl_ProductName = new Label();
            lbl_ProductPrice = new Label();
            lbl_BeschreibungÜberschrift = new Label();
            lbl_BeschreibungInhalt = new Label();
            btn_Kaufen = new Button();
            btn_WarenkorbProduktAnsicht = new Button();
            lbl_Bestseller = new Label();
            label1 = new Label();
            pBXProductPicBestseller1 = new PictureBox();
            btn_WarenkorbProduct2 = new Button();
            lbl_ProductPriceBestseller1 = new Label();
            lbl_ProductNameBestseller1 = new Label();
            btn_BackToMain2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pBXMainProductPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pBXProductPicBestseller1).BeginInit();
            SuspendLayout();
            // 
            // pBXMainProductPic
            // 
            pBXMainProductPic.Image = Properties.Resources.doener;
            pBXMainProductPic.InitialImage = null;
            pBXMainProductPic.Location = new Point(371, 30);
            pBXMainProductPic.Name = "pBXMainProductPic";
            pBXMainProductPic.Size = new Size(160, 214);
            pBXMainProductPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXMainProductPic.TabIndex = 0;
            pBXMainProductPic.TabStop = false;
            pBXMainProductPic.Click += pictureBox1_Click;
            // 
            // lbl_ProductName
            // 
            lbl_ProductName.AutoSize = true;
            lbl_ProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProductName.Location = new Point(549, 46);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(64, 25);
            lbl_ProductName.TabIndex = 1;
            lbl_ProductName.Text = "Döner";
            // 
            // lbl_ProductPrice
            // 
            lbl_ProductPrice.AutoSize = true;
            lbl_ProductPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProductPrice.Location = new Point(550, 71);
            lbl_ProductPrice.Name = "lbl_ProductPrice";
            lbl_ProductPrice.Size = new Size(66, 25);
            lbl_ProductPrice.TabIndex = 2;
            lbl_ProductPrice.Text = "8 Euro";
            // 
            // lbl_BeschreibungÜberschrift
            // 
            lbl_BeschreibungÜberschrift.AutoSize = true;
            lbl_BeschreibungÜberschrift.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_BeschreibungÜberschrift.Location = new Point(547, 113);
            lbl_BeschreibungÜberschrift.Name = "lbl_BeschreibungÜberschrift";
            lbl_BeschreibungÜberschrift.Size = new Size(127, 25);
            lbl_BeschreibungÜberschrift.TabIndex = 3;
            lbl_BeschreibungÜberschrift.Text = "Beschreibung";
            lbl_BeschreibungÜberschrift.Click += lbl_BeschreibungÜberschrift_Click;
            // 
            // lbl_BeschreibungInhalt
            // 
            lbl_BeschreibungInhalt.AutoSize = true;
            lbl_BeschreibungInhalt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_BeschreibungInhalt.Location = new Point(550, 138);
            lbl_BeschreibungInhalt.Name = "lbl_BeschreibungInhalt";
            lbl_BeschreibungInhalt.Size = new Size(191, 17);
            lbl_BeschreibungInhalt.TabIndex = 4;
            lbl_BeschreibungInhalt.Text = "Dieses Produkt ist heeeeeeeftig";
            lbl_BeschreibungInhalt.Click += lbl_BeschreibungInhalt_Click;
            // 
            // btn_Kaufen
            // 
            btn_Kaufen.Location = new Point(551, 218);
            btn_Kaufen.Name = "btn_Kaufen";
            btn_Kaufen.Size = new Size(96, 26);
            btn_Kaufen.TabIndex = 5;
            btn_Kaufen.Text = "Kaufen";
            btn_Kaufen.UseVisualStyleBackColor = true;
            // 
            // btn_WarenkorbProduktAnsicht
            // 
            btn_WarenkorbProduktAnsicht.Location = new Point(653, 218);
            btn_WarenkorbProduktAnsicht.Name = "btn_WarenkorbProduktAnsicht";
            btn_WarenkorbProduktAnsicht.Size = new Size(96, 26);
            btn_WarenkorbProduktAnsicht.TabIndex = 6;
            btn_WarenkorbProduktAnsicht.Text = "Warenkorb";
            btn_WarenkorbProduktAnsicht.UseVisualStyleBackColor = true;
            // 
            // lbl_Bestseller
            // 
            lbl_Bestseller.AutoSize = true;
            lbl_Bestseller.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Bestseller.Location = new Point(216, 272);
            lbl_Bestseller.Name = "lbl_Bestseller";
            lbl_Bestseller.Size = new Size(156, 25);
            lbl_Bestseller.TabIndex = 7;
            lbl_Bestseller.Text = "Unsere Bestseller";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(291, 219);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 8;
            // 
            // pBXProductPicBestseller1
            // 
            pBXProductPicBestseller1.Image = Properties.Resources.dueruem;
            pBXProductPicBestseller1.Location = new Point(233, 300);
            pBXProductPicBestseller1.Name = "pBXProductPicBestseller1";
            pBXProductPicBestseller1.Size = new Size(118, 97);
            pBXProductPicBestseller1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXProductPicBestseller1.TabIndex = 17;
            pBXProductPicBestseller1.TabStop = false;
            // 
            // btn_WarenkorbProduct2
            // 
            btn_WarenkorbProduct2.Location = new Point(278, 410);
            btn_WarenkorbProduct2.Name = "btn_WarenkorbProduct2";
            btn_WarenkorbProduct2.Size = new Size(73, 20);
            btn_WarenkorbProduct2.TabIndex = 18;
            btn_WarenkorbProduct2.Text = "Warenkorb";
            btn_WarenkorbProduct2.UseVisualStyleBackColor = true;
            // 
            // lbl_ProductPriceBestseller1
            // 
            lbl_ProductPriceBestseller1.AutoSize = true;
            lbl_ProductPriceBestseller1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProductPriceBestseller1.Location = new Point(232, 415);
            lbl_ProductPriceBestseller1.Name = "lbl_ProductPriceBestseller1";
            lbl_ProductPriceBestseller1.Size = new Size(40, 15);
            lbl_ProductPriceBestseller1.TabIndex = 20;
            lbl_ProductPriceBestseller1.Text = "8 Euro";
            // 
            // lbl_ProductNameBestseller1
            // 
            lbl_ProductNameBestseller1.AutoSize = true;
            lbl_ProductNameBestseller1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProductNameBestseller1.Location = new Point(232, 400);
            lbl_ProductNameBestseller1.Name = "lbl_ProductNameBestseller1";
            lbl_ProductNameBestseller1.Size = new Size(44, 15);
            lbl_ProductNameBestseller1.TabIndex = 19;
            lbl_ProductNameBestseller1.Text = "Dürüm";
            // 
            // btn_BackToMain2
            // 
            btn_BackToMain2.Location = new Point(28, 476);
            btn_BackToMain2.Name = "btn_BackToMain2";
            btn_BackToMain2.Size = new Size(96, 26);
            btn_BackToMain2.TabIndex = 21;
            btn_BackToMain2.Text = "Zurück";
            btn_BackToMain2.UseVisualStyleBackColor = true;
            // 
            // produktansicht
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_BackToMain2);
            Controls.Add(lbl_ProductPriceBestseller1);
            Controls.Add(lbl_ProductNameBestseller1);
            Controls.Add(btn_WarenkorbProduct2);
            Controls.Add(pBXProductPicBestseller1);
            Controls.Add(label1);
            Controls.Add(lbl_Bestseller);
            Controls.Add(btn_WarenkorbProduktAnsicht);
            Controls.Add(btn_Kaufen);
            Controls.Add(lbl_BeschreibungInhalt);
            Controls.Add(lbl_BeschreibungÜberschrift);
            Controls.Add(lbl_ProductPrice);
            Controls.Add(lbl_ProductName);
            Controls.Add(pBXMainProductPic);
            Name = "produktansicht";
            Size = new Size(853, 514);
            ((System.ComponentModel.ISupportInitialize)pBXMainProductPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pBXProductPicBestseller1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBXMainProductPic;
        private Label lbl_ProductName;
        private Label lbl_ProductPrice;
        private Label lbl_BeschreibungÜberschrift;
        private Label lbl_BeschreibungInhalt;
        private Button btn_Kaufen;
        private Button btn_WarenkorbProduktAnsicht;
        private Label lbl_Bestseller;
        private Label label1;
        private PictureBox pBXProductPicBestseller1;
        private Button btn_WarenkorbProduct2;
        private Label lbl_ProductPriceBestseller1;
        private Label lbl_ProductNameBestseller1;
        private Button btn_BackToMain2;
    }
}