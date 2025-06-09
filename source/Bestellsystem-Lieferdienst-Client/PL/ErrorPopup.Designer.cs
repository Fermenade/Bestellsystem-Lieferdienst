using Bestellsystem_Lieferdienst_Client;

namespace Bestellsystem_Lieferdienst.PL
{
    partial class ErrorPopup
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
            btn_close = new Button();
            lb_Error = new Label();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Location = new Point(827, 13);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(34, 34);
            btn_close.TabIndex = 0;
            btn_close.Text = "X";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // lb_Error
            // 
            lb_Error.AutoSize = true;
            lb_Error.Location = new Point(20, 37);
            lb_Error.Name = "lb_Error";
            lb_Error.Size = new Size(50, 25);
            lb_Error.TabIndex = 1;
            lb_Error.Text = "Error";
            // 
            // ErrorPopup
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            Controls.Add(lb_Error);
            Left = 0;
            Top = 0;
            Controls.Add(btn_close);
            Name = "ErrorPopup";
            Size = new Size(879, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_close;
        private Label lb_Error;
    }
}
