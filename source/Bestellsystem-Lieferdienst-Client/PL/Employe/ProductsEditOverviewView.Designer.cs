namespace Bestellsystem_Lieferdienst_Client.PL.Employe
{
    partial class ProductsEditOverviewView
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
            btn_ReturnToStart = new Button();
            btn_newProduct = new Button();
            SuspendLayout();
            // 
            // btn_ReturnToStart
            // 
            btn_ReturnToStart.Location = new Point(2014, 77);
            btn_ReturnToStart.Name = "btn_ReturnToStart";
            btn_ReturnToStart.Size = new Size(264, 58);
            btn_ReturnToStart.TabIndex = 0;
            btn_ReturnToStart.Text = "Züruck zu strat";
            btn_ReturnToStart.UseVisualStyleBackColor = true;
            btn_ReturnToStart.Click += btn_ReturnToStart_Click;
            // 
            // btn_newProduct
            // 
            btn_newProduct.Location = new Point(1388, 80);
            btn_newProduct.Name = "btn_newProduct";
            btn_newProduct.Size = new Size(188, 58);
            btn_newProduct.TabIndex = 1;
            btn_newProduct.Text = "Neu";
            btn_newProduct.UseVisualStyleBackColor = true;
            btn_newProduct.Click += btn_newProduct_Click;
            // 
            // ProductsEditOverviewView
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btn_newProduct);
            Controls.Add(btn_ReturnToStart);
            Margin = new Padding(5);
            Name = "ProductsEditOverviewView";
            Size = new Size(2977, 1509);
            ResumeLayout(false);
        }

        #endregion

        private Button btn_ReturnToStart;
        private Button btn_newProduct;
    }
}
