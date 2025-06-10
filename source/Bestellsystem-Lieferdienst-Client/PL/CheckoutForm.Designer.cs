using Bestellsystem_Lieferdienst_Client.BL.ShopingCart;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using Bestellsystem_Lieferdienst_Client.PL.ShopingCart_Controls;

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
            lbl_PLZ = new Label();
            tbx_PLZ = new TextBox();
            lbl_Stadt = new Label();
            tbx_Stadt = new TextBox();
            tbx_StraßeHausnummer = new TextBox();
            lbl_StraßeHausnummer = new Label();
            btn_KaufAbschließen = new Button();
            button1 = new Button();
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
            // lbl_PLZ
            // 
            lbl_PLZ.AutoSize = true;
            lbl_PLZ.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PLZ.Location = new Point(774, 248);
            lbl_PLZ.Margin = new Padding(4, 0, 4, 0);
            lbl_PLZ.Name = "lbl_PLZ";
            lbl_PLZ.Size = new Size(48, 28);
            lbl_PLZ.TabIndex = 1;
            lbl_PLZ.Text = "PLZ:";
            // 
            // tbx_PLZ
            // 
            tbx_PLZ.Location = new Point(776, 278);
            tbx_PLZ.Margin = new Padding(4, 5, 4, 5);
            tbx_PLZ.Name = "tbx_PLZ";
            tbx_PLZ.Size = new Size(235, 31);
            tbx_PLZ.TabIndex = 2;
            tbx_PLZ.TextChanged += tbx_PLZ_TextChanged;
            // 
            // lbl_Stadt
            // 
            lbl_Stadt.AutoSize = true;
            lbl_Stadt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Stadt.Location = new Point(773, 337);
            lbl_Stadt.Margin = new Padding(4, 0, 4, 0);
            lbl_Stadt.Name = "lbl_Stadt";
            lbl_Stadt.Size = new Size(62, 28);
            lbl_Stadt.TabIndex = 3;
            lbl_Stadt.Text = "Stadt:";
            // 
            // tbx_Stadt
            // 
            tbx_Stadt.Location = new Point(776, 367);
            tbx_Stadt.Margin = new Padding(4, 5, 4, 5);
            tbx_Stadt.Name = "tbx_Stadt";
            tbx_Stadt.Size = new Size(234, 31);
            tbx_Stadt.TabIndex = 4;
            // 
            // tbx_StraßeHausnummer
            // 
            tbx_StraßeHausnummer.Location = new Point(774, 465);
            tbx_StraßeHausnummer.Margin = new Padding(4, 5, 4, 5);
            tbx_StraßeHausnummer.Name = "tbx_StraßeHausnummer";
            tbx_StraßeHausnummer.Size = new Size(234, 31);
            tbx_StraßeHausnummer.TabIndex = 6;
            // 
            // lbl_StraßeHausnummer
            // 
            lbl_StraßeHausnummer.AutoSize = true;
            lbl_StraßeHausnummer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_StraßeHausnummer.Location = new Point(771, 435);
            lbl_StraßeHausnummer.Margin = new Padding(4, 0, 4, 0);
            lbl_StraßeHausnummer.Name = "lbl_StraßeHausnummer";
            lbl_StraßeHausnummer.Size = new Size(238, 28);
            lbl_StraßeHausnummer.TabIndex = 5;
            lbl_StraßeHausnummer.Text = "Straße und Hausnummert:";
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
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            Controls.Add(button1);
            Controls.Add(btn_KaufAbschließen);
            Controls.Add(tbx_StraßeHausnummer);
            Controls.Add(lbl_StraßeHausnummer);
            Controls.Add(tbx_Stadt);
            Controls.Add(lbl_Stadt);
            Controls.Add(tbx_PLZ);
            Controls.Add(lbl_PLZ);
            Controls.Add(lbl_BestellungÜberschrift);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CheckoutForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_BestellungÜberschrift;
        private Label lbl_PLZ;
        private TextBox tbx_PLZ;
        private Label lbl_Stadt;
        private TextBox tbx_Stadt;
        private TextBox tbx_StraßeHausnummer;
        private Label lbl_StraßeHausnummer;
        private Button btn_KaufAbschließen;
        private ShoppingCartView shoppingCart = new();
        private Button button1;
    }
}
