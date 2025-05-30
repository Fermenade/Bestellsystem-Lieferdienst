using Bestellsystem_Lieferdienst_Client.PL;

namespace Bestellsystem_Lieferdienst.PL
{
    partial class ShoppingCardEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShoppingCardEntry));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 31);
            numericUpDown1.TabIndex = 0;
            // 
            // ShoppingCardEntry
            // 
            Controls.Add(pictureBox1);
            Size = new Size(479, 101);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private NumericUpDown numericUpDown1;

        void InitializeManualComponent()
        {
            Height = 100;
            BackColor = Color.Aqua;

            pictureBox1.Left = Width - 90;

            label1.Left = 10;
            label1.Top = 0;
            label1.BackColor = Color.Black;
        }
    }
}
