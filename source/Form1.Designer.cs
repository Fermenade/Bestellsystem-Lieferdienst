namespace Bestellsystem_Lieferdienst
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            btn_Login = new System.Windows.Forms.Button();
            btn_Register = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new System.Drawing.Point(1233, 12);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new System.Drawing.Size(123, 54);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Register
            // 
            btn_Register.Location = new System.Drawing.Point(1024, 12);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new System.Drawing.Size(193, 54);
            btn_Register.TabIndex = 7;
            btn_Register.Text = "Registrieren";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1381, 709);
            Controls.Add(btn_Register);
            Controls.Add(btn_Login);
            Text = "Form1";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Button btn_Login;

        #endregion

        public void InitializeManualComponent()
        {
            //Disable resizablility
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            ResumeLayout(false);
        }
    }
}
