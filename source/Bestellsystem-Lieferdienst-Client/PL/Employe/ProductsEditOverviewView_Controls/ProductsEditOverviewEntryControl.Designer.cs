namespace Bestellsystem_Lieferdienst_Client.PL.Employe.ProductsEditOverviewView_Controls
{
    partial class ProductsEditOverviewEntryControl
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
            lb_Name = new Label();
            lb_description = new Label();
            lb_price = new Label();
            btn_Delete = new Button();
            btn_Edit = new Button();
            btn_Show = new Button();
            SuspendLayout();
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.Location = new Point(55, 49);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(59, 25);
            lb_Name.TabIndex = 0;
            lb_Name.Text = "Name";
            // 
            // lb_description
            // 
            lb_description.AutoSize = true;
            lb_description.Location = new Point(296, 49);
            lb_description.Name = "lb_description";
            lb_description.Size = new Size(100, 25);
            lb_description.TabIndex = 1;
            lb_description.Text = "description";
            // 
            // lb_price
            // 
            lb_price.AutoSize = true;
            lb_price.Location = new Point(873, 62);
            lb_price.Name = "lb_price";
            lb_price.Size = new Size(66, 25);
            lb_price.TabIndex = 2;
            lb_price.Text = "99,99€";
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(1103, 63);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(88, 34);
            btn_Delete.TabIndex = 3;
            btn_Delete.Text = "Löschen";
            btn_Delete.UseVisualStyleBackColor = true;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(1211, 64);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(112, 34);
            btn_Edit.TabIndex = 4;
            btn_Edit.Text = "Bearbeiten";
            btn_Edit.UseVisualStyleBackColor = true;
            // 
            // btn_Show
            // 
            btn_Show.Location = new Point(1349, 66);
            btn_Show.Name = "btn_Show";
            btn_Show.Size = new Size(112, 34);
            btn_Show.TabIndex = 5;
            btn_Show.Text = "Anzeigen";
            btn_Show.UseVisualStyleBackColor = true;
            // 
            // ProductsEditOverviewEntryControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_Show);
            Controls.Add(btn_Edit);
            Controls.Add(btn_Delete);
            Controls.Add(lb_price);
            Controls.Add(lb_description);
            Controls.Add(lb_Name);
            Name = "ProductsEditOverviewEntryControl";
            BorderStyle = BorderStyle.FixedSingle;
            Size = new Size(1527, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Name;
        private Label lb_description;
        private Label lb_price;
        public Button btn_Delete;
        public Button btn_Edit;
        public Button btn_Show;
    }
}
