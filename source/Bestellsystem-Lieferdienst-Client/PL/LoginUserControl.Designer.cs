using System.ComponentModel;

namespace Bestellsystem_Lieferdienst_Client.PL;

partial class LoginUserControl : UserControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
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

    #region Component Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        btn_Login_Login = new System.Windows.Forms.Button();
        btn_Login_Register = new System.Windows.Forms.Button();
        lb_Login_EMail = new System.Windows.Forms.Label();
        lb_Login_Password = new System.Windows.Forms.Label();
        textBox1 = new System.Windows.Forms.TextBox();
        tbx_Login_Passwort = new System.Windows.Forms.TextBox();
        SuspendLayout();
        // 
        // btn_Login_Login
        // 
        btn_Login_Login.Location = new System.Drawing.Point(354, 488);
        btn_Login_Login.Name = "btn_Login_Login";
        btn_Login_Login.Size = new System.Drawing.Size(162, 64);
        btn_Login_Login.TabIndex = 1;
        btn_Login_Login.Text = "Anmelden";
        btn_Login_Login.UseVisualStyleBackColor = true;
        // 
        // btn_Login_Register
        // 
        btn_Login_Register.Location = new System.Drawing.Point(645, 501);
        btn_Login_Register.Name = "btn_Login_Register";
        btn_Login_Register.Size = new System.Drawing.Size(197, 51);
        btn_Login_Register.TabIndex = 2;
        btn_Login_Register.Text = "Registrieren";
        btn_Login_Register.UseVisualStyleBackColor = true;
        // 
        // lb_Login_EMail
        // 
        lb_Login_EMail.Location = new System.Drawing.Point(371, 90);
        lb_Login_EMail.Name = "lb_Login_EMail";
        lb_Login_EMail.Size = new System.Drawing.Size(104, 44);
        lb_Login_EMail.TabIndex = 3;
        lb_Login_EMail.Text = "E-Mail";
        // 
        // lb_Login_Password
        // 
        lb_Login_Password.Location = new System.Drawing.Point(354, 275);
        lb_Login_Password.Name = "lb_Login_Password";
        lb_Login_Password.Size = new System.Drawing.Size(144, 44);
        lb_Login_Password.TabIndex = 4;
        lb_Login_Password.Text = "Passwort";
        // 
        // textBox1
        // 
        textBox1.Location = new System.Drawing.Point(354, 331);
        textBox1.Name = "textBox1";
        textBox1.Size = new System.Drawing.Size(434, 47);
        textBox1.TabIndex = 5;
        // 
        // tbx_Login_Passwort
        // 
        tbx_Login_Passwort.Location = new System.Drawing.Point(384, 154);
        tbx_Login_Passwort.Name = "tbx_Login_Passwort";
        tbx_Login_Passwort.Size = new System.Drawing.Size(458, 47);
        tbx_Login_Passwort.TabIndex = 6;
        // 
        // LoginUserControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        Controls.Add(tbx_Login_Passwort);
        Controls.Add(textBox1);
        Controls.Add(lb_Login_Password);
        Controls.Add(lb_Login_EMail);
        Controls.Add(btn_Login_Register);
        Controls.Add(btn_Login_Login);
        Size = new System.Drawing.Size(1230, 746);
        ResumeLayout(false);
        PerformLayout();
    }
        private System.Windows.Forms.Button btn_Login_Login;
        private System.Windows.Forms.Button btn_Login_Register;
        private System.Windows.Forms.Label lb_Login_EMail;
        private System.Windows.Forms.Label lb_Login_Password;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbx_Login_Passwort;

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Login button clicked!");
            // Add your login logic here, like validating the username and password.
        }
    #endregion

    public void InitializeManualComponent()
    { }
}