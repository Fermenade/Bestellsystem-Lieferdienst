namespace Bestellsystem_Lieferdienst_Client.PL.Admin
{
    partial class Console
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
            richTextBoxConsole = new RichTextBox();
            textBox1 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // richTextBoxConsole
            // 
            richTextBoxConsole.Location = new Point(56, 46);
            richTextBoxConsole.Name = "richTextBoxConsole";
            richTextBoxConsole.Size = new Size(1103, 842);
            richTextBoxConsole.TabIndex = 1;
            richTextBoxConsole.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 912);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(876, 31);
            textBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(1165, 17);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "zurück";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.button1_Click;
            // 
            // Console
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(richTextBoxConsole);
            Name = "Console";
            Size = new Size(1286, 969);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox richTextBoxConsole;
        private TextBox textBox1;
        private Button button1;
    }
}
