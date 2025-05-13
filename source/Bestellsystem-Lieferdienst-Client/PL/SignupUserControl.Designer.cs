using System.ComponentModel;

namespace Bestellsystem_Lieferdienst.PL;

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
        btn_Signup = new System.Windows.Forms.Button();
        lb_Email = new System.Windows.Forms.Label();
        tbx_Email = new System.Windows.Forms.TextBox();
        tbx_Password = new System.Windows.Forms.TextBox();
        lb_Password = new System.Windows.Forms.Label();
        lb_Error = new System.Windows.Forms.Label();
        tbx_Lastname = new System.Windows.Forms.TextBox();
        lb_Lastname = new System.Windows.Forms.Label();
        tbx_Firstname = new System.Windows.Forms.TextBox();
        lb_Firstname = new System.Windows.Forms.Label();
        tbx_Street = new System.Windows.Forms.TextBox();
        lb_Street = new System.Windows.Forms.Label();
        tbx_City = new System.Windows.Forms.TextBox();
        lb_City = new System.Windows.Forms.Label();
        tbx_ZippCode = new System.Windows.Forms.TextBox();
        lb_ZippCode = new System.Windows.Forms.Label();
        tbx_Country = new System.Windows.Forms.TextBox();
        lb_Country = new System.Windows.Forms.Label();
        tbx_ApartmentNr = new System.Windows.Forms.TextBox();
        lb_ApartmentNr = new System.Windows.Forms.Label();
        tbx_HouseNr = new System.Windows.Forms.TextBox();
        lb_HouseNr = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // btn_Signup
        // 
        btn_Signup.Location = new System.Drawing.Point(386, 636);
        btn_Signup.Name = "btn_Signup";
        btn_Signup.Size = new System.Drawing.Size(164, 71);
        btn_Signup.TabIndex = 0;
        btn_Signup.Text = "Signup";
        btn_Signup.UseVisualStyleBackColor = true;
        btn_Signup.Click += BtnSignupClick;
        // 
        // lb_Email
        // 
        lb_Email.Location = new System.Drawing.Point(195, 11);
        lb_Email.Name = "lb_Email";
        lb_Email.Size = new System.Drawing.Size(141, 70);
        lb_Email.TabIndex = 1;
        lb_Email.Text = "E-Mail";
        // 
        // tbx_Email
        // 
        tbx_Email.Location = new System.Drawing.Point(195, 63);
        tbx_Email.Name = "tbx_Email";
        tbx_Email.Size = new System.Drawing.Size(201, 47);
        tbx_Email.TabIndex = 2;
        // 
        // tbx_Password
        // 
        tbx_Password.Location = new System.Drawing.Point(195, 166);
        tbx_Password.Name = "tbx_Password";
        tbx_Password.Size = new System.Drawing.Size(201, 47);
        tbx_Password.TabIndex = 4;
        // 
        // lb_Password
        // 
        lb_Password.Location = new System.Drawing.Point(195, 114);
        lb_Password.Name = "lb_Password";
        lb_Password.Size = new System.Drawing.Size(141, 70);
        lb_Password.TabIndex = 3;
        lb_Password.Text = "Passwort";
        // 
        // lb_Error
        // 
        lb_Error.Location = new System.Drawing.Point(230, 551);
        lb_Error.Name = "lb_Error";
        lb_Error.Size = new System.Drawing.Size(687, 95);
        lb_Error.TabIndex = 5;
        lb_Error.Text = "Error";
        // 
        // tbx_Lastname
        // 
        tbx_Lastname.Location = new System.Drawing.Point(195, 371);
        tbx_Lastname.Name = "tbx_Lastname";
        tbx_Lastname.Size = new System.Drawing.Size(201, 47);
        tbx_Lastname.TabIndex = 9;
        // 
        // lb_Lastname
        // 
        lb_Lastname.Location = new System.Drawing.Point(195, 319);
        lb_Lastname.Name = "lb_Lastname";
        lb_Lastname.Size = new System.Drawing.Size(172, 49);
        lb_Lastname.TabIndex = 8;
        lb_Lastname.Text = "Nachname";
        // 
        // tbx_Firstname
        // 
        tbx_Firstname.Location = new System.Drawing.Point(195, 268);
        tbx_Firstname.Name = "tbx_Firstname";
        tbx_Firstname.Size = new System.Drawing.Size(201, 47);
        tbx_Firstname.TabIndex = 7;
        // 
        // lb_Firstname
        // 
        lb_Firstname.Location = new System.Drawing.Point(195, 216);
        lb_Firstname.Name = "lb_Firstname";
        lb_Firstname.Size = new System.Drawing.Size(141, 70);
        lb_Firstname.TabIndex = 6;
        lb_Firstname.Text = "Vorname";
        // 
        // tbx_Street
        // 
        tbx_Street.Location = new System.Drawing.Point(543, 370);
        tbx_Street.Name = "tbx_Street";
        tbx_Street.Size = new System.Drawing.Size(201, 47);
        tbx_Street.TabIndex = 17;
        // 
        // lb_Street
        // 
        lb_Street.Location = new System.Drawing.Point(543, 318);
        lb_Street.Name = "lb_Street";
        lb_Street.Size = new System.Drawing.Size(172, 49);
        lb_Street.TabIndex = 16;
        lb_Street.Text = "Straße";
        // 
        // tbx_City
        // 
        tbx_City.Location = new System.Drawing.Point(543, 267);
        tbx_City.Name = "tbx_City";
        tbx_City.Size = new System.Drawing.Size(201, 47);
        tbx_City.TabIndex = 15;
        // 
        // lb_City
        // 
        lb_City.Location = new System.Drawing.Point(543, 215);
        lb_City.Name = "lb_City";
        lb_City.Size = new System.Drawing.Size(141, 70);
        lb_City.TabIndex = 14;
        lb_City.Text = "Stadt";
        // 
        // tbx_ZippCode
        // 
        tbx_ZippCode.Location = new System.Drawing.Point(543, 165);
        tbx_ZippCode.Name = "tbx_ZippCode";
        tbx_ZippCode.Size = new System.Drawing.Size(201, 47);
        tbx_ZippCode.TabIndex = 13;
        // 
        // lb_ZippCode
        // 
        lb_ZippCode.Location = new System.Drawing.Point(543, 113);
        lb_ZippCode.Name = "lb_ZippCode";
        lb_ZippCode.Size = new System.Drawing.Size(141, 70);
        lb_ZippCode.TabIndex = 12;
        lb_ZippCode.Text = "PLZ";
        // 
        // tbx_Country
        // 
        tbx_Country.Location = new System.Drawing.Point(543, 62);
        tbx_Country.Name = "tbx_Country";
        tbx_Country.Size = new System.Drawing.Size(201, 47);
        tbx_Country.TabIndex = 11;
        // 
        // lb_Country
        // 
        lb_Country.Location = new System.Drawing.Point(543, 10);
        lb_Country.Name = "lb_Country";
        lb_Country.Size = new System.Drawing.Size(141, 70);
        lb_Country.TabIndex = 10;
        lb_Country.Text = "Land";
        // 
        // tbx_ApartmentNr
        // 
        tbx_ApartmentNr.Location = new System.Drawing.Point(775, 165);
        tbx_ApartmentNr.Name = "tbx_ApartmentNr";
        tbx_ApartmentNr.Size = new System.Drawing.Size(201, 47);
        tbx_ApartmentNr.TabIndex = 21;
        // 
        // lb_ApartmentNr
        // 
        lb_ApartmentNr.Location = new System.Drawing.Point(775, 113);
        lb_ApartmentNr.Name = "lb_ApartmentNr";
        lb_ApartmentNr.Size = new System.Drawing.Size(172, 49);
        lb_ApartmentNr.TabIndex = 20;
        lb_ApartmentNr.Text = "Apartmentnr.";
        // 
        // tbx_HouseNr
        // 
        tbx_HouseNr.Location = new System.Drawing.Point(775, 62);
        tbx_HouseNr.Name = "tbx_HouseNr";
        tbx_HouseNr.Size = new System.Drawing.Size(201, 47);
        tbx_HouseNr.TabIndex = 19;
        // 
        // lb_HouseNr
        // 
        lb_HouseNr.Location = new System.Drawing.Point(775, 10);
        lb_HouseNr.Name = "lb_HouseNr";
        lb_HouseNr.Size = new System.Drawing.Size(141, 70);
        lb_HouseNr.TabIndex = 18;
        lb_HouseNr.Text = "Hausnr.";
        // 
        // SignupUserControl
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
        Size = new System.Drawing.Size(1287, 707);
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