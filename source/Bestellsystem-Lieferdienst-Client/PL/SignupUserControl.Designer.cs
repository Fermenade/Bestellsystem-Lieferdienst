using System.ComponentModel;

namespace Bestellsystem_Lieferdienst_Client.PL;

partial class SignupUserControl
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
        btn_Signup = new Button();
        lb_Email = new Label();
        tbx_Email = new TextBox();
        tbx_Password = new TextBox();
        lb_Password = new Label();
        lb_Error = new Label();
        tbx_Lastname = new TextBox();
        lb_Lastname = new Label();
        tbx_Firstname = new TextBox();
        lb_Firstname = new Label();
        tbx_Street = new TextBox();
        lb_Street = new Label();
        tbx_City = new TextBox();
        lb_City = new Label();
        tbx_ZippCode = new TextBox();
        lb_ZippCode = new Label();
        tbx_Country = new TextBox();
        lb_Country = new Label();
        tbx_ApartmentNr = new TextBox();
        lb_ApartmentNr = new Label();
        tbx_HouseNr = new TextBox();
        lb_HouseNr = new Label();
        SuspendLayout();
        // 
        // btn_Signup
        // 
        btn_Signup.Location = new Point(159, 251);
        btn_Signup.Margin = new Padding(1, 1, 1, 1);
        btn_Signup.Name = "btn_Signup";
        btn_Signup.Size = new Size(68, 26);
        btn_Signup.TabIndex = 0;
        btn_Signup.Text = "Signup";
        btn_Signup.UseVisualStyleBackColor = true;
        btn_Signup.Click += BtnSignupClick;
        // 
        // lb_Email
        // 
        lb_Email.Location = new Point(84, 18);
        lb_Email.Margin = new Padding(1, 0, 1, 0);
        lb_Email.Name = "lb_Email";
        lb_Email.Size = new Size(58, 26);
        lb_Email.TabIndex = 1;
        lb_Email.Text = "E-Mail";
        // 
        // tbx_Email
        // 
        tbx_Email.Location = new Point(84, 37);
        tbx_Email.Margin = new Padding(1, 1, 1, 1);
        tbx_Email.Name = "tbx_Email";
        tbx_Email.Size = new Size(85, 23);
        tbx_Email.TabIndex = 2;
        // 
        // tbx_Password
        // 
        tbx_Password.Location = new Point(83, 93);
        tbx_Password.Margin = new Padding(1, 1, 1, 1);
        tbx_Password.Name = "tbx_Password";
        tbx_Password.Size = new Size(85, 23);
        tbx_Password.TabIndex = 4;
        // 
        // lb_Password
        // 
        lb_Password.Location = new Point(83, 74);
        lb_Password.Margin = new Padding(1, 0, 1, 0);
        lb_Password.Name = "lb_Password";
        lb_Password.Size = new Size(58, 26);
        lb_Password.TabIndex = 3;
        lb_Password.Text = "Passwort";
        // 
        // lb_Error
        // 
        lb_Error.Location = new Point(95, 220);
        lb_Error.Margin = new Padding(1, 0, 1, 0);
        lb_Error.Name = "lb_Error";
        lb_Error.Size = new Size(283, 30);
        lb_Error.TabIndex = 5;
        lb_Error.Text = "Error";
        // 
        // tbx_Lastname
        // 
        tbx_Lastname.Location = new Point(83, 192);
        tbx_Lastname.Margin = new Padding(1, 1, 1, 1);
        tbx_Lastname.Name = "tbx_Lastname";
        tbx_Lastname.Size = new Size(85, 23);
        tbx_Lastname.TabIndex = 9;
        // 
        // lb_Lastname
        // 
        lb_Lastname.Location = new Point(83, 173);
        lb_Lastname.Margin = new Padding(1, 0, 1, 0);
        lb_Lastname.Name = "lb_Lastname";
        lb_Lastname.Size = new Size(71, 18);
        lb_Lastname.TabIndex = 8;
        lb_Lastname.Text = "Nachname";
        // 
        // tbx_Firstname
        // 
        tbx_Firstname.Location = new Point(83, 140);
        tbx_Firstname.Margin = new Padding(1, 1, 1, 1);
        tbx_Firstname.Name = "tbx_Firstname";
        tbx_Firstname.Size = new Size(85, 23);
        tbx_Firstname.TabIndex = 7;
        // 
        // lb_Firstname
        // 
        lb_Firstname.Location = new Point(83, 121);
        lb_Firstname.Margin = new Padding(1, 0, 1, 0);
        lb_Firstname.Name = "lb_Firstname";
        lb_Firstname.Size = new Size(58, 26);
        lb_Firstname.TabIndex = 6;
        lb_Firstname.Text = "Vorname";
        // 
        // tbx_Street
        // 
        tbx_Street.Location = new Point(227, 192);
        tbx_Street.Margin = new Padding(1, 1, 1, 1);
        tbx_Street.Name = "tbx_Street";
        tbx_Street.Size = new Size(85, 23);
        tbx_Street.TabIndex = 17;
        // 
        // lb_Street
        // 
        lb_Street.Location = new Point(227, 173);
        lb_Street.Margin = new Padding(1, 0, 1, 0);
        lb_Street.Name = "lb_Street";
        lb_Street.Size = new Size(71, 18);
        lb_Street.TabIndex = 16;
        lb_Street.Text = "Straße";
        // 
        // tbx_City
        // 
        tbx_City.Location = new Point(227, 140);
        tbx_City.Margin = new Padding(1, 1, 1, 1);
        tbx_City.Name = "tbx_City";
        tbx_City.Size = new Size(85, 23);
        tbx_City.TabIndex = 15;
        // 
        // lb_City
        // 
        lb_City.Location = new Point(227, 121);
        lb_City.Margin = new Padding(1, 0, 1, 0);
        lb_City.Name = "lb_City";
        lb_City.Size = new Size(58, 26);
        lb_City.TabIndex = 14;
        lb_City.Text = "Stadt";
        // 
        // tbx_ZippCode
        // 
        tbx_ZippCode.Location = new Point(227, 92);
        tbx_ZippCode.Margin = new Padding(1, 1, 1, 1);
        tbx_ZippCode.Name = "tbx_ZippCode";
        tbx_ZippCode.Size = new Size(85, 23);
        tbx_ZippCode.TabIndex = 13;
        // 
        // lb_ZippCode
        // 
        lb_ZippCode.Location = new Point(227, 73);
        lb_ZippCode.Margin = new Padding(1, 0, 1, 0);
        lb_ZippCode.Name = "lb_ZippCode";
        lb_ZippCode.Size = new Size(58, 26);
        lb_ZippCode.TabIndex = 12;
        lb_ZippCode.Text = "PLZ";
        // 
        // tbx_Country
        // 
        tbx_Country.Location = new Point(228, 37);
        tbx_Country.Margin = new Padding(1, 1, 1, 1);
        tbx_Country.Name = "tbx_Country";
        tbx_Country.Size = new Size(85, 23);
        tbx_Country.TabIndex = 11;
        // 
        // lb_Country
        // 
        lb_Country.Location = new Point(228, 18);
        lb_Country.Margin = new Padding(1, 0, 1, 0);
        lb_Country.Name = "lb_Country";
        lb_Country.Size = new Size(58, 26);
        lb_Country.TabIndex = 10;
        lb_Country.Text = "Land";
        // 
        // tbx_ApartmentNr
        // 
        tbx_ApartmentNr.Location = new Point(322, 92);
        tbx_ApartmentNr.Margin = new Padding(1, 1, 1, 1);
        tbx_ApartmentNr.Name = "tbx_ApartmentNr";
        tbx_ApartmentNr.Size = new Size(85, 23);
        tbx_ApartmentNr.TabIndex = 21;
        // 
        // lb_ApartmentNr
        // 
        lb_ApartmentNr.Location = new Point(322, 73);
        lb_ApartmentNr.Margin = new Padding(1, 0, 1, 0);
        lb_ApartmentNr.Name = "lb_ApartmentNr";
        lb_ApartmentNr.Size = new Size(71, 18);
        lb_ApartmentNr.TabIndex = 20;
        lb_ApartmentNr.Text = "Apartmentnr.";
        // 
        // tbx_HouseNr
        // 
        tbx_HouseNr.Location = new Point(323, 37);
        tbx_HouseNr.Margin = new Padding(1, 1, 1, 1);
        tbx_HouseNr.Name = "tbx_HouseNr";
        tbx_HouseNr.Size = new Size(85, 23);
        tbx_HouseNr.TabIndex = 19;
        // 
        // lb_HouseNr
        // 
        lb_HouseNr.Location = new Point(323, 18);
        lb_HouseNr.Margin = new Padding(1, 0, 1, 0);
        lb_HouseNr.Name = "lb_HouseNr";
        lb_HouseNr.Size = new Size(58, 26);
        lb_HouseNr.TabIndex = 18;
        lb_HouseNr.Text = "Hausnr.";
        // 
        // SignupUserControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(tbx_ApartmentNr);
        Controls.Add(lb_ApartmentNr);
        Controls.Add(tbx_HouseNr);
        Controls.Add(lb_HouseNr);
        Controls.Add(tbx_Street);
        Controls.Add(lb_Street);
        Controls.Add(tbx_City);
        Controls.Add(lb_City);
        Controls.Add(tbx_ZippCode);
        Controls.Add(lb_ZippCode);
        Controls.Add(tbx_Country);
        Controls.Add(lb_Country);
        Controls.Add(tbx_Lastname);
        Controls.Add(lb_Lastname);
        Controls.Add(tbx_Firstname);
        Controls.Add(lb_Firstname);
        Controls.Add(lb_Error);
        Controls.Add(tbx_Password);
        Controls.Add(lb_Password);
        Controls.Add(tbx_Email);
        Controls.Add(lb_Email);
        Controls.Add(btn_Signup);
        Margin = new Padding(1, 1, 1, 1);
        Name = "SignupUserControl";
        Size = new Size(530, 287);
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.TextBox tbx_Street;
    private System.Windows.Forms.Label lb_Street;
    private System.Windows.Forms.TextBox tbx_City;
    private System.Windows.Forms.Label lb_City;
    private System.Windows.Forms.TextBox tbx_ZippCode;
    private System.Windows.Forms.Label lb_ZippCode;
    private System.Windows.Forms.TextBox tbx_Country;
    private System.Windows.Forms.Label lb_Country;
    private System.Windows.Forms.TextBox tbx_ApartmentNr;
    private System.Windows.Forms.Label lb_ApartmentNr;
    private System.Windows.Forms.TextBox tbx_HouseNr;
    private System.Windows.Forms.Label lb_HouseNr;

    private System.Windows.Forms.Label lb_Lastname;
    private System.Windows.Forms.TextBox tbx_Lastname;
    private System.Windows.Forms.TextBox tbx_Firstname;
    private System.Windows.Forms.Label lb_Firstname;

    private System.Windows.Forms.Label lb_Error;

    private System.Windows.Forms.Button btn_Signup;
    private System.Windows.Forms.Label lb_Email;
    private System.Windows.Forms.TextBox tbx_Email;
    private System.Windows.Forms.TextBox tbx_Password;
    private System.Windows.Forms.Label lb_Password;

    #endregion
}