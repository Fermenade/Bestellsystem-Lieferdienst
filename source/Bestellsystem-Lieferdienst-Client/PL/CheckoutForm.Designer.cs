namespace Bestellsystem_Lieferdienst.PL
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
            lbl_BestellungWarenkorb = new Label();
            lbl_BestellungGesamtpreis = new Label();
            SuspendLayout();
            // 
            // lbl_BestellungÜberschrift
            // 
            lbl_BestellungÜberschrift.AutoSize = true;
            lbl_BestellungÜberschrift.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_BestellungÜberschrift.Location = new Point(341, 44);
            lbl_BestellungÜberschrift.Name = "lbl_BestellungÜberschrift";
            lbl_BestellungÜberschrift.Size = new Size(101, 25);
            lbl_BestellungÜberschrift.TabIndex = 0;
            lbl_BestellungÜberschrift.Text = "Bestellung";
            // 
            // lbl_PLZ
            // 
            lbl_PLZ.AutoSize = true;
            lbl_PLZ.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_PLZ.Location = new Point(542, 149);
            lbl_PLZ.Name = "lbl_PLZ";
            lbl_PLZ.Size = new Size(31, 17);
            lbl_PLZ.TabIndex = 1;
            lbl_PLZ.Text = "PLZ:";
            // 
            // tbx_PLZ
            // 
            tbx_PLZ.Location = new Point(543, 167);
            tbx_PLZ.Name = "tbx_PLZ";
            tbx_PLZ.Size = new Size(166, 23);
            tbx_PLZ.TabIndex = 2;
            tbx_PLZ.TextChanged += tbx_PLZ_TextChanged;
            // 
            // lbl_Stadt
            // 
            lbl_Stadt.AutoSize = true;
            lbl_Stadt.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_Stadt.Location = new Point(541, 202);
            lbl_Stadt.Name = "lbl_Stadt";
            lbl_Stadt.Size = new Size(41, 17);
            lbl_Stadt.TabIndex = 3;
            lbl_Stadt.Text = "Stadt:";
            // 
            // tbx_Stadt
            // 
            tbx_Stadt.Location = new Point(543, 220);
            tbx_Stadt.Name = "tbx_Stadt";
            tbx_Stadt.Size = new Size(165, 23);
            tbx_Stadt.TabIndex = 4;
            // 
            // tbx_StraßeHausnummer
            // 
            tbx_StraßeHausnummer.Location = new Point(542, 279);
            tbx_StraßeHausnummer.Name = "tbx_StraßeHausnummer";
            tbx_StraßeHausnummer.Size = new Size(165, 23);
            tbx_StraßeHausnummer.TabIndex = 6;
            // 
            // lbl_StraßeHausnummer
            // 
            lbl_StraßeHausnummer.AutoSize = true;
            lbl_StraßeHausnummer.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_StraßeHausnummer.Location = new Point(540, 261);
            lbl_StraßeHausnummer.Name = "lbl_StraßeHausnummer";
            lbl_StraßeHausnummer.Size = new Size(159, 17);
            lbl_StraßeHausnummer.TabIndex = 5;
            lbl_StraßeHausnummer.Text = "Straße und Hausnummert:";
            // 
            // btn_KaufAbschließen
            // 
            btn_KaufAbschließen.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_KaufAbschließen.Location = new Point(341, 415);
            btn_KaufAbschließen.Name = "btn_KaufAbschließen";
            btn_KaufAbschließen.Size = new Size(100, 54);
            btn_KaufAbschließen.TabIndex = 7;
            btn_KaufAbschließen.Text = "Kauf Abschließen";
            btn_KaufAbschließen.UseVisualStyleBackColor = true;
            // 
            // lbl_BestellungWarenkorb
            // 
            lbl_BestellungWarenkorb.AutoSize = true;
            lbl_BestellungWarenkorb.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_BestellungWarenkorb.Location = new Point(84, 107);
            lbl_BestellungWarenkorb.Name = "lbl_BestellungWarenkorb";
            lbl_BestellungWarenkorb.Size = new Size(87, 21);
            lbl_BestellungWarenkorb.TabIndex = 8;
            lbl_BestellungWarenkorb.Text = "Warenkorb";
            // 
            // lbl_BestellungGesamtpreis
            // 
            lbl_BestellungGesamtpreis.AutoSize = true;
            lbl_BestellungGesamtpreis.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_BestellungGesamtpreis.Location = new Point(84, 327);
            lbl_BestellungGesamtpreis.Name = "lbl_BestellungGesamtpreis";
            lbl_BestellungGesamtpreis.Size = new Size(44, 21);
            lbl_BestellungGesamtpreis.TabIndex = 9;
            lbl_BestellungGesamtpreis.Text = "Preis";
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_BestellungGesamtpreis);
            Controls.Add(lbl_BestellungWarenkorb);
            Controls.Add(btn_KaufAbschließen);
            Controls.Add(tbx_StraßeHausnummer);
            Controls.Add(lbl_StraßeHausnummer);
            Controls.Add(tbx_Stadt);
            Controls.Add(lbl_Stadt);
            Controls.Add(tbx_PLZ);
            Controls.Add(lbl_PLZ);
            Controls.Add(lbl_BestellungÜberschrift);
            Name = "UserControl1";
            Size = new Size(811, 572);
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
        private Label lbl_BestellungWarenkorb;
        private Label lbl_BestellungGesamtpreis;
    }
}
