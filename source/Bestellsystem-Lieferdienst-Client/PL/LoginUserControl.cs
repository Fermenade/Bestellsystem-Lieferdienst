namespace Bestellsystem_Lieferdienst_Client.PL;

partial class LoginUserControl
{
    public LoginUserControl()
    {
        InitializeComponent();
        InitializeManualComponent();
    }
    private Label lblEmail;
    private TextBox tbxUserName;
    private Label lblPassword;
    private Label lblLogin;
    private Button btnLogin;
    private Button btn_GoToMain;
    private Button button1;
    private Label lbl_Login;
    private Label lbl_Mail;
    private Label lbl_Password;
    private TextBox tbx_Mail;
    private TextBox tbx_Pass;
    private Button btn_BackToMain;
    private Button btn_Login;
    private TextBox tbx_Password;

    private void InitializeComponent()
    {
        lbl_Login = new Label();
        lbl_Mail = new Label();
        lbl_Password = new Label();
        tbx_Mail = new TextBox();
        tbx_Pass = new TextBox();
        btn_GoToMain = new Button();
        btn_Login = new Button();
        SuspendLayout();
        // 
        // lbl_Login
        // 
        lbl_Login.AutoSize = true;
        lbl_Login.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl_Login.Location = new Point(116, 38);
        lbl_Login.Name = "lbl_Login";
        lbl_Login.Size = new Size(75, 30);
        lbl_Login.TabIndex = 0;
        lbl_Login.Text = "LOGIN";
        // 
        // lbl_Mail
        // 
        lbl_Mail.AutoSize = true;
        lbl_Mail.Location = new Point(77, 100);
        lbl_Mail.Name = "lbl_Mail";
        lbl_Mail.Size = new Size(44, 15);
        lbl_Mail.TabIndex = 1;
        lbl_Mail.Text = "E-Mail:";
        // 
        // lbl_Password
        // 
        lbl_Password.AutoSize = true;
        lbl_Password.Location = new Point(77, 161);
        lbl_Password.Name = "lbl_Password";
        lbl_Password.Size = new Size(57, 15);
        lbl_Password.TabIndex = 2;
        lbl_Password.Text = "Passwort:";
        // 
        // tbx_Mail
        // 
        tbx_Mail.Location = new Point(77, 118);
        tbx_Mail.Name = "tbx_Mail";
        tbx_Mail.Size = new Size(156, 23);
        tbx_Mail.TabIndex = 3;
        // 
        // tbx_Pass
        // 
        tbx_Pass.Location = new Point(77, 179);
        tbx_Pass.Name = "tbx_Pass";
        tbx_Pass.Size = new Size(156, 23);
        tbx_Pass.TabIndex = 4;
        // 
        // btn_GoToMain
        // 
        btn_GoToMain.Location = new Point(77, 233);
        btn_GoToMain.Name = "btn_GoToMain";
        btn_GoToMain.Size = new Size(75, 23);
        btn_GoToMain.TabIndex = 5;
        btn_GoToMain.Text = "Zurück";
        btn_GoToMain.UseVisualStyleBackColor = true;
        // 
        // btn_Login
        // 
        btn_Login.Location = new Point(158, 233);
        btn_Login.Name = "btn_Login";
        btn_Login.Size = new Size(75, 23);
        btn_Login.TabIndex = 6;
        btn_Login.Text = "Login";
        btn_Login.UseVisualStyleBackColor = true;
        // 
        // LoginUserControl
        // 
        Controls.Add(btn_Login);
        Controls.Add(btn_GoToMain);
        Controls.Add(tbx_Pass);
        Controls.Add(tbx_Mail);
        Controls.Add(lbl_Password);
        Controls.Add(lbl_Mail);
        Controls.Add(lbl_Login);
        Name = "LoginUserControl";
        Size = new Size(298, 370);
        ResumeLayout(false);
        PerformLayout();

    }

    //private void InitializeComponent()
    //{
    //    this.lbl_Email = new Label();
    //    this.tbx_UserName = new TextBox();
    //    this.lbl_Password = new Label();
    //    tbx_Password = new TextBox();
    //    this.lbl_Login = new Label();
    //    btn_BackToMain = new Button();
    //    this.btn_Login = new Button();
    //    SuspendLayout();
    //    // 
    //    // lbl_Email
    //    // 
    //    this.lbl_Email.AutoSize = true;
    //    this.lbl_Email.Location = new Point(79, 80);
    //    this.lbl_Email.Name = "lbl_Email";
    //    this.lbl_Email.Size = new Size(44, 15);
    //    this.lbl_Email.TabIndex = 0;
    //    this.lbl_Email.Text = "E-Mail:";
    //    // 
    //    // tbx_UserName
    //    // 
    //    this.tbx_UserName.Location = new Point(79, 98);
    //    this.tbx_UserName.Name = "tbx_UserName";
    //    this.tbx_UserName.Size = new Size(163, 23);
    //    this.tbx_UserName.TabIndex = 1;
    //    // 
    //    // lbl_Password
    //    // 
    //    this.lbl_Password.AutoSize = true;
    //    this.lbl_Password.Location = new Point(79, 124);
    //    this.lbl_Password.Name = "lbl_Password";
    //    this.lbl_Password.Size = new Size(57, 15);
    //    this.lbl_Password.TabIndex = 2;
    //    this.lbl_Password.Text = "Passwort:";
    //    // 
    //    // tbx_Password
    //    // 
    //    tbx_Password.Location = new Point(79, 142);
    //    tbx_Password.Name = "tbx_Password";
    //    tbx_Password.Size = new Size(163, 23);
    //    tbx_Password.TabIndex = 3;
    //    tbx_Password.TextChanged += tbxPassword_TextChanged;
    //    // 
    //    // lbl_Login
    //    // 
    //    this.lbl_Login.AutoSize = true;
    //    this.lbl_Login.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
    //    this.lbl_Login.Location = new Point(118, 22);
    //    this.lbl_Login.Name = "lbl_Login";
    //    this.lbl_Login.Size = new Size(75, 30);
    //    this.lbl_Login.TabIndex = 4;
    //    this.lbl_Login.Text = "LOGIN";
    //    // 
    //    // btn_BackToMain
    //    // 
    //    btn_BackToMain.Location = new Point(79, 191);
    //    btn_BackToMain.Margin = new Padding(1);
    //    btn_BackToMain.Name = "btn_BackToMain";
    //    btn_BackToMain.Size = new Size(68, 26);
    //    btn_BackToMain.TabIndex = 23;
    //    btn_BackToMain.Text = "Zurück";
    //    btn_BackToMain.UseVisualStyleBackColor = true;
    //    // 
    //    // btn_Login
    //    // 
    //    this.btn_Login.Location = new Point(154, 191);
    //    this.btn_Login.Margin = new Padding(1);
    //    this.btn_Login.Name = "btn_Login";
    //    this.btn_Login.Size = new Size(68, 26);
    //    this.btn_Login.TabIndex = 24;
    //    this.btn_Login.Text = "Login";
    //    this.btn_Login.UseVisualStyleBackColor = true;
    //    // 
    //    // LoginUserControl
    //    // 
    //    Controls.Add(this.btn_Login);
    //    Controls.Add(btn_BackToMain);
    //    Controls.Add(this.lbl_Login);
    //    Controls.Add(tbx_Password);
    //    Controls.Add(this.lbl_Password);
    //    Controls.Add(this.tbx_UserName);
    //    Controls.Add(this.lbl_Email);
    //    Name = "LoginUserControl";
    //    Size = new Size(317, 281);
    //    ResumeLayout(false);
    //    PerformLayout();

    //}

    private void tbxPassword_TextChanged(object sender, EventArgs e)
    {

    }


}