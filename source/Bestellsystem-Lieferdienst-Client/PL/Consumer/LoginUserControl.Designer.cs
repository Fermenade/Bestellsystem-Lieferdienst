namespace Bestellsystem_Lieferdienst_Client.PL;

partial class LoginUserControl
{
    private Button btn_GoToMain;
    private Label lbl_Login;
    private Label lbl_Mail;
    private Label lbl_Password;
    private TextBox tbx_Mail;
    private TextBox tbx_Pass;
    private Button btn_Login;

    private void InitializeComponent()
    {
        lbl_Login = new Label();
        lbl_Mail = new Label();
        lbl_Password = new Label();
        tbx_Mail = new TextBox();
        tbx_Pass = new TextBox();
        btn_GoToMain = new Button();
        btn_Login = new Button();
        lb_error = new Label();
        SuspendLayout();
        // 
        // lbl_Login
        // 
        lbl_Login.AutoSize = true;
        lbl_Login.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl_Login.Location = new Point(116, 38);
        lbl_Login.Name = "lbl_Login";
        lbl_Login.Size = new Size(115, 45);
        lbl_Login.TabIndex = 0;
        lbl_Login.Text = "LOGIN";
        // 
        // lbl_Mail
        // 
        lbl_Mail.AutoSize = true;
        lbl_Mail.Location = new Point(77, 100);
        lbl_Mail.Name = "lbl_Mail";
        lbl_Mail.Size = new Size(65, 25);
        lbl_Mail.TabIndex = 1;
        lbl_Mail.Text = "E-Mail:";
        // 
        // lbl_Password
        // 
        lbl_Password.AutoSize = true;
        lbl_Password.Location = new Point(77, 161);
        lbl_Password.Name = "lbl_Password";
        lbl_Password.Size = new Size(86, 25);
        lbl_Password.TabIndex = 2;
        lbl_Password.Text = "Passwort:";
        // 
        // tbx_Mail
        // 
        tbx_Mail.Location = new Point(77, 126);
        tbx_Mail.Name = "tbx_Mail";
        tbx_Mail.Size = new Size(156, 31);
        tbx_Mail.TabIndex = 3;
        // 
        // tbx_Pass
        // 
        tbx_Pass.Location = new Point(77, 189);
        tbx_Pass.Name = "tbx_Pass";
        tbx_Pass.Size = new Size(156, 31);
        tbx_Pass.TabIndex = 4;
        // 
        // btn_GoToMain
        // 
        btn_GoToMain.Location = new Point(77, 314);
        btn_GoToMain.Name = "btn_GoToMain";
        btn_GoToMain.Size = new Size(86, 48);
        btn_GoToMain.TabIndex = 5;
        btn_GoToMain.Text = "Zurück";
        btn_GoToMain.UseVisualStyleBackColor = true;
        btn_GoToMain.Click += btn_GoToMain_Click;
        // 
        // btn_Login
        // 
        btn_Login.Location = new Point(189, 314);
        btn_Login.Name = "btn_Login";
        btn_Login.Size = new Size(85, 48);
        btn_Login.TabIndex = 6;
        btn_Login.Text = "Login";
        btn_Login.UseVisualStyleBackColor = true;
        btn_Login.Click += btn_Login_Click;
        // 
        // lb_error
        // 
        lb_error.AutoSize = true;
        lb_error.Location = new Point(77, 239);
        lb_error.Name = "lb_error";
        lb_error.Size = new Size(0, 25);
        lb_error.TabIndex = 7;
        // 
        // LoginUserControl
        // 
        Controls.Add(lb_error);
        Controls.Add(btn_Login);
        Controls.Add(btn_GoToMain);
        Controls.Add(tbx_Pass);
        Controls.Add(tbx_Mail);
        Controls.Add(lbl_Password);
        Controls.Add(lbl_Mail);
        Controls.Add(lbl_Login);
        Name = "LoginUserControl";
        Size = new Size(839, 672);
        ResumeLayout(false);
        PerformLayout();

    }
    private Label lb_error;
}