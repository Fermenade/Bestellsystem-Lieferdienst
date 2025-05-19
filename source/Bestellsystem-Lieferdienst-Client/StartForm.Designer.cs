using Bestellsystem_Lieferdienst_Client.PL;

namespace Bestellsystem_Lieferdienst_Client
{
    partial class StartForm
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
            btn_Login = new Button();
            btn_Register = new Button();
            pBXProduct1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pBXProduct1).BeginInit();
            SuspendLayout();
            // 
            // btn_Login
            // 
            btn_Login.Location = new Point(508, 4);
            btn_Login.Margin = new Padding(1, 1, 1, 1);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(51, 20);
            btn_Login.TabIndex = 0;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = true;
            btn_Login.Click += btn_Login_Click;
            // 
            // btn_Register
            // 
            btn_Register.Location = new Point(422, 4);
            btn_Register.Margin = new Padding(1, 1, 1, 1);
            btn_Register.Name = "btn_Register";
            btn_Register.Size = new Size(79, 20);
            btn_Register.TabIndex = 7;
            btn_Register.Text = "Registrieren";
            btn_Register.UseVisualStyleBackColor = true;
            btn_Register.Click += btn_Register_Click;
            // 
            // pBXProduct1
            // 
            pBXProduct1.Image = Bestellsystem_Lieferdienst.Properties.Resources.Screenshot_2024_05_27_090755;
            pBXProduct1.Location = new Point(475, 64);
            pBXProduct1.Name = "pBXProduct1";
            pBXProduct1.Size = new Size(82, 117);
            pBXProduct1.SizeMode = PictureBoxSizeMode.StretchImage;
            pBXProduct1.TabIndex = 8;
            pBXProduct1.TabStop = false;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 259);
            Controls.Add(pBXProduct1);
            Controls.Add(btn_Register);
            Controls.Add(btn_Login);
            Margin = new Padding(1, 1, 1, 1);
            Name = "StartForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pBXProduct1).EndInit();
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
            ShoppingCart e = new ShoppingCart();
            ResumeLayout(false);
        }
        private PictureBox pBXProduct1;
    }
}
