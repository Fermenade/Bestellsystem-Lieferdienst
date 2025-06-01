namespace Bestellsystem_Lieferdienst.PL
{
    partial class ShoppingCartView
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

            // Header Labels
            Label lblTitle = new Label { Text = "Name", Left = 10, Width = 120, Top = 10, ForeColor = Color.Black };
            Label lblAmount = new Label { Text = "Menge", Left = 140, Width = 80, Top = 10, ForeColor = Color.Black };
            Label lblTotal = new Label { Text = "Total", Left = 260, Width = 60, Top = 10, ForeColor = Color.Black };

            // Header Panel
            this.headerPanel = new Panel();
            this.headerPanel.Dock = DockStyle.Top;
            this.headerPanel.Height = 40;
            this.headerPanel.Width = 60;
            this.headerPanel.BorderStyle = BorderStyle.FixedSingle;
            this.headerPanel.BackColor = Color.AliceBlue;

            this.headerPanel.Controls.AddRange(new Control[] { lblTitle, lblAmount, lblTotal });

            Height = 800;
            BackColor = Color.LightGray;
            SuspendLayout();
            // cartPanel
            Dock = DockStyle.Left; // or DockStyle.Left
            Width = 460; // or whatever width you want
            AutoScroll = true;
            FlowDirection = FlowDirection.TopDown; 
            WrapContents = false; 
            // ShoppingCartView
            ResumeLayout(false);
        }

        #endregion
        private Panel headerPanel;
    }
}
