using Bestellsystem_Lieferdienst_Client.BL.ShopingCart;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Bestellsystem_Lieferdienst.PL.Konsument.ShopingCart_Controls;

namespace Bestellsystem_Lieferdienst_Client.PL
{
    partial class CheckoutForm
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
                CartManager.CartItems.ListChanged -= listChangedHandler;
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
            lbl_BestellungÜberschrift = new Label();
            btn_KaufAbschließen = new Button();
            button1 = new Button();
            tbxApartment = new TextBox();
            lblApartmentNummer = new Label();
            tbxHausnummer = new TextBox();
            lblHausnummer = new Label();
            tbxOrt = new TextBox();
            lblOrt = new Label();
            tbxLand = new TextBox();
            lblLand = new Label();
            tbxPLZ = new TextBox();
            lblPLZ = new Label();
            tbxStraße = new TextBox();
            lblStraße = new Label();
            lb_error = new Label();
            SuspendLayout();
            // 
            // lbl_BestellungÜberschrift
            // 
            lbl_BestellungÜberschrift.AutoSize = true;
            lbl_BestellungÜberschrift.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BestellungÜberschrift.Location = new Point(487, 73);
            lbl_BestellungÜberschrift.Margin = new Padding(4, 0, 4, 0);
            lbl_BestellungÜberschrift.Name = "lbl_BestellungÜberschrift";
            lbl_BestellungÜberschrift.Size = new Size(155, 40);
            lbl_BestellungÜberschrift.TabIndex = 0;
            lbl_BestellungÜberschrift.Text = "Bestellung";
            // 
            // btn_KaufAbschließen
            // 
            btn_KaufAbschließen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_KaufAbschließen.Location = new Point(487, 692);
            btn_KaufAbschließen.Margin = new Padding(4, 5, 4, 5);
            btn_KaufAbschließen.Name = "btn_KaufAbschließen";
            btn_KaufAbschließen.Size = new Size(143, 90);
            btn_KaufAbschließen.TabIndex = 7;
            btn_KaufAbschließen.Text = "Kauf Abschließen";
            btn_KaufAbschließen.UseVisualStyleBackColor = true;
            btn_KaufAbschließen.Click += btn_KaufAbschließen_Click;
            // 
            // button1
            // 
            button1.Location = new Point(867, 43);
            button1.Name = "button1";
            button1.Size = new Size(186, 34);
            button1.TabIndex = 8;
            button1.Text = "Zurück zur Startseite";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tbxApartment
            // 
            tbxApartment.Location = new Point(946, 403);
            tbxApartment.Margin = new Padding(4, 5, 4, 5);
            tbxApartment.Name = "tbxApartment";
            tbxApartment.Size = new Size(301, 31);
            tbxApartment.TabIndex = 28;
            // 
            // lblApartmentNummer
            // 
            lblApartmentNummer.AutoSize = true;
            lblApartmentNummer.Location = new Point(946, 373);
            lblApartmentNummer.Margin = new Padding(4, 0, 4, 0);
            lblApartmentNummer.Name = "lblApartmentNummer";
            lblApartmentNummer.Size = new Size(164, 25);
            lblApartmentNummer.TabIndex = 27;
            lblApartmentNummer.Text = "Apartmentnummer";
            // 
            // tbxHausnummer
            // 
            tbxHausnummer.Location = new Point(946, 310);
            tbxHausnummer.Margin = new Padding(4, 5, 4, 5);
            tbxHausnummer.Name = "tbxHausnummer";
            tbxHausnummer.Size = new Size(301, 31);
            tbxHausnummer.TabIndex = 26;
            // 
            // lblHausnummer
            // 
            lblHausnummer.AutoSize = true;
            lblHausnummer.Location = new Point(946, 280);
            lblHausnummer.Margin = new Padding(4, 0, 4, 0);
            lblHausnummer.Name = "lblHausnummer";
            lblHausnummer.Size = new Size(119, 25);
            lblHausnummer.TabIndex = 25;
            lblHausnummer.Text = "Hausnummer";
            // 
            // tbxOrt
            // 
            tbxOrt.Location = new Point(946, 611);
            tbxOrt.Margin = new Padding(4, 5, 4, 5);
            tbxOrt.Name = "tbxOrt";
            tbxOrt.Size = new Size(301, 31);
            tbxOrt.TabIndex = 24;
            // 
            // lblOrt
            // 
            lblOrt.AutoSize = true;
            lblOrt.Location = new Point(946, 581);
            lblOrt.Margin = new Padding(4, 0, 4, 0);
            lblOrt.Name = "lblOrt";
            lblOrt.Size = new Size(38, 25);
            lblOrt.TabIndex = 23;
            lblOrt.Text = "Ort";
            // 
            // tbxLand
            // 
            tbxLand.Location = new Point(946, 713);
            tbxLand.Margin = new Padding(4, 5, 4, 5);
            tbxLand.Name = "tbxLand";
            tbxLand.Size = new Size(301, 31);
            tbxLand.TabIndex = 22;
            // 
            // lblLand
            // 
            lblLand.AutoSize = true;
            lblLand.Location = new Point(946, 683);
            lblLand.Margin = new Padding(4, 0, 4, 0);
            lblLand.Name = "lblLand";
            lblLand.Size = new Size(50, 25);
            lblLand.TabIndex = 21;
            lblLand.Text = "Land";
            // 
            // tbxPLZ
            // 
            tbxPLZ.Location = new Point(946, 503);
            tbxPLZ.Margin = new Padding(4, 5, 4, 5);
            tbxPLZ.Name = "tbxPLZ";
            tbxPLZ.Size = new Size(301, 31);
            tbxPLZ.TabIndex = 20;
            // 
            // lblPLZ
            // 
            lblPLZ.AutoSize = true;
            lblPLZ.Location = new Point(946, 473);
            lblPLZ.Margin = new Padding(4, 0, 4, 0);
            lblPLZ.Name = "lblPLZ";
            lblPLZ.Size = new Size(41, 25);
            lblPLZ.TabIndex = 19;
            lblPLZ.Text = "PLZ";
            // 
            // tbxStraße
            // 
            tbxStraße.Location = new Point(946, 218);
            tbxStraße.Margin = new Padding(4, 5, 4, 5);
            tbxStraße.Name = "tbxStraße";
            tbxStraße.Size = new Size(301, 31);
            tbxStraße.TabIndex = 18;
            // 
            // lblStraße
            // 
            lblStraße.AutoSize = true;
            lblStraße.Location = new Point(946, 188);
            lblStraße.Margin = new Padding(4, 0, 4, 0);
            lblStraße.Name = "lblStraße";
            lblStraße.Size = new Size(61, 25);
            lblStraße.TabIndex = 17;
            lblStraße.Text = "Straße";
            // 
            // lb_error
            // 
            lb_error.AutoSize = true;
            lb_error.Location = new Point(727, 799);
            lb_error.Name = "lb_error";
            lb_error.Size = new Size(59, 25);
            lb_error.TabIndex = 29;
            lb_error.Text = "label1";
            // 
            // CheckoutForm
            // 
            Controls.Add(lb_error);
            Controls.Add(tbxApartment);
            Controls.Add(lblApartmentNummer);
            Controls.Add(tbxHausnummer);
            Controls.Add(lblHausnummer);
            Controls.Add(tbxOrt);
            Controls.Add(lblOrt);
            Controls.Add(tbxLand);
            Controls.Add(lblLand);
            Controls.Add(tbxPLZ);
            Controls.Add(lblPLZ);
            Controls.Add(tbxStraße);
            Controls.Add(lblStraße);
            Controls.Add(button1);
            Controls.Add(btn_KaufAbschließen);
            Controls.Add(lbl_BestellungÜberschrift);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CheckoutForm";
            Size = new Size(1525, 1019);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_BestellungÜberschrift;
        private Button btn_KaufAbschließen;
        private ShoppingCartView shoppingCart = new();
        private Button button1;
        private TextBox tbxApartment;
        private Label lblApartmentNummer;
        private TextBox tbxHausnummer;
        private Label lblHausnummer;
        private TextBox tbxOrt;
        private Label lblOrt;
        private TextBox tbxLand;
        private Label lblLand;
        private TextBox tbxPLZ;
        private Label lblPLZ;
        private TextBox tbxStraße;
        private Label lblStraße;
        private Label lb_error;
    }
}
