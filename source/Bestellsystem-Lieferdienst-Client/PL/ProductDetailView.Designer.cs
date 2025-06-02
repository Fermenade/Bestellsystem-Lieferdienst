using Bestellsystem_Lieferdienst.PL.ShopingCart;

namespace Bestellsystem_Lieferdienst.PL
{
    partial class ProductDetailView
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
            pBXMainProductPic.Location = new Point(530, 50);
            pBXMainProductPic.Margin = new Padding(4, 5, 4, 5);
            pBXMainProductPic.Name = "pBXMainProductPic";
            pBXMainProductPic.Size = new Size(229, 357);
            pBXMainProductPic.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXMainProductPic.TabIndex = 0;
            pBXMainProductPic.TabStop = false;
            pBXMainProductPic.Click += pictureBox1_Click;
            // 
            // lbl_ProductName
            // 
            lbl_ProductName.AutoSize = true;
            lbl_ProductName.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProductName.Location = new Point(784, 77);
            lbl_ProductName.Margin = new Padding(4, 0, 4, 0);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(95, 40);
            lbl_ProductName.TabIndex = 1;
            lbl_ProductName.Text = "Döner";
            // 
            // lbl_ProductPrice
            // 
            lbl_ProductPrice.AutoSize = true;
            lbl_ProductPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProductPrice.Location = new Point(786, 118);
            lbl_ProductPrice.Margin = new Padding(4, 0, 4, 0);
            lbl_ProductPrice.Name = "lbl_ProductPrice";
            lbl_ProductPrice.Size = new Size(99, 40);
            lbl_ProductPrice.TabIndex = 2;
            lbl_ProductPrice.Text = "8 Euro";
            // 
            // lbl_BeschreibungÜberschrift
            // 
            lbl_BeschreibungÜberschrift.AutoSize = true;
            lbl_BeschreibungÜberschrift.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_BeschreibungÜberschrift.Location = new Point(781, 188);
            lbl_BeschreibungÜberschrift.Margin = new Padding(4, 0, 4, 0);
            lbl_BeschreibungÜberschrift.Name = "lbl_BeschreibungÜberschrift";
            lbl_BeschreibungÜberschrift.Size = new Size(188, 40);
            lbl_BeschreibungÜberschrift.TabIndex = 3;
            lbl_BeschreibungÜberschrift.Text = "Beschreibung";
            lbl_BeschreibungÜberschrift.Click += lbl_BeschreibungÜberschrift_Click;
            // 
            // lbl_BeschreibungInhalt
            // 
            lbl_BeschreibungInhalt.AutoSize = true;
            lbl_BeschreibungInhalt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_BeschreibungInhalt.Location = new Point(786, 230);
            lbl_BeschreibungInhalt.Margin = new Padding(4, 0, 4, 0);
            lbl_BeschreibungInhalt.Name = "lbl_BeschreibungInhalt";
            lbl_BeschreibungInhalt.Size = new Size(283, 28);
            lbl_BeschreibungInhalt.TabIndex = 4;
            lbl_BeschreibungInhalt.Text = "Dieses Produkt ist heeeeeeeftig";
            lbl_BeschreibungInhalt.Click += lbl_BeschreibungInhalt_Click;
            // 
            // btn_Kaufen
            // 
            btn_Kaufen.Location = new Point(787, 363);
            btn_Kaufen.Margin = new Padding(4, 5, 4, 5);
            btn_Kaufen.Name = "btn_Kaufen";
            btn_Kaufen.Size = new Size(137, 43);
            btn_Kaufen.TabIndex = 5;
            btn_Kaufen.Text = "Kaufen";
            btn_Kaufen.UseVisualStyleBackColor = true;
            btn_Kaufen.Click += btn_Kaufen_Click;
            // 
            // btn_WarenkorbProduktAnsicht
            // 
            btn_WarenkorbProduktAnsicht.Location = new Point(933, 363);
            btn_WarenkorbProduktAnsicht.Margin = new Padding(4, 5, 4, 5);
            btn_WarenkorbProduktAnsicht.Name = "btn_WarenkorbProduktAnsicht";
            btn_WarenkorbProduktAnsicht.Size = new Size(137, 43);
            btn_WarenkorbProduktAnsicht.TabIndex = 6;
            btn_WarenkorbProduktAnsicht.Text = "Warenkorb";
            btn_WarenkorbProduktAnsicht.UseVisualStyleBackColor = true;
            btn_WarenkorbProduktAnsicht.Click += btn_WarenkorbProduktAnsicht_Click;
            // 
            // lbl_Bestseller
            // 
            lbl_Bestseller.AutoSize = true;
            lbl_Bestseller.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Bestseller.Location = new Point(309, 453);
            lbl_Bestseller.Margin = new Padding(4, 0, 4, 0);
            lbl_Bestseller.Name = "lbl_Bestseller";
            lbl_Bestseller.Size = new Size(233, 40);
            lbl_Bestseller.TabIndex = 7;
            lbl_Bestseller.Text = "Unsere Bestseller";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(416, 365);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 40);
            label1.TabIndex = 8;
            // 
            // pBXProductPicBestseller1
            // 
            pBXProductPicBestseller1.Image = Properties.Resources.dueruem;
            pBXProductPicBestseller1.Location = new Point(333, 500);
            pBXProductPicBestseller1.Margin = new Padding(4, 5, 4, 5);
            pBXProductPicBestseller1.Name = "pBXProductPicBestseller1";
            pBXProductPicBestseller1.Size = new Size(169, 162);
            pBXProductPicBestseller1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXProductPicBestseller1.TabIndex = 17;
            pBXProductPicBestseller1.TabStop = false;
            // 
            // btn_WarenkorbProduct2
            // 
            btn_WarenkorbProduct2.Location = new Point(397, 683);
            btn_WarenkorbProduct2.Margin = new Padding(4, 5, 4, 5);
            btn_WarenkorbProduct2.Name = "btn_WarenkorbProduct2";
            btn_WarenkorbProduct2.Size = new Size(104, 33);
            btn_WarenkorbProduct2.TabIndex = 18;
            btn_WarenkorbProduct2.Text = "Warenkorb";
            btn_WarenkorbProduct2.UseVisualStyleBackColor = true;
            // 
            // lbl_ProductPriceBestseller1
            // 
            lbl_ProductPriceBestseller1.AutoSize = true;
            lbl_ProductPriceBestseller1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProductPriceBestseller1.Location = new Point(331, 692);
            lbl_ProductPriceBestseller1.Margin = new Padding(4, 0, 4, 0);
            lbl_ProductPriceBestseller1.Name = "lbl_ProductPriceBestseller1";
            lbl_ProductPriceBestseller1.Size = new Size(63, 25);
            lbl_ProductPriceBestseller1.TabIndex = 20;
            lbl_ProductPriceBestseller1.Text = "8 Euro";
            // 
            // lbl_ProductNameBestseller1
            // 
            lbl_ProductNameBestseller1.AutoSize = true;
            lbl_ProductNameBestseller1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ProductNameBestseller1.Location = new Point(331, 667);
            lbl_ProductNameBestseller1.Margin = new Padding(4, 0, 4, 0);
            lbl_ProductNameBestseller1.Name = "lbl_ProductNameBestseller1";
            lbl_ProductNameBestseller1.Size = new Size(67, 25);
            lbl_ProductNameBestseller1.TabIndex = 19;
            lbl_ProductNameBestseller1.Text = "Dürüm";
            // 
            // btn_BackToMain2
            // 
            btn_BackToMain2.Location = new Point(40, 793);
            btn_BackToMain2.Margin = new Padding(4, 5, 4, 5);
            btn_BackToMain2.Name = "btn_BackToMain2";
            btn_BackToMain2.Size = new Size(137, 43);
            btn_BackToMain2.TabIndex = 21;
            btn_BackToMain2.Text = "Zurück";
            btn_BackToMain2.UseVisualStyleBackColor = true;
            btn_BackToMain2.Click += btn_BackToMain2_Click;
            // 
            // ProductDetailView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
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
            Margin = new Padding(4, 5, 4, 5);
            Name = "ProductDetailView";
            Size = new Size(1219, 857);
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
        private ShoppingCartView shoppingCart = new();
        void InitializeManualComponent()
        {
            Controls.Add(shoppingCart);
        }
    }
}