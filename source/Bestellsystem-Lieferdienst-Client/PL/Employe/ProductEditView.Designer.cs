namespace Bestellsystem_Lieferdienst_Client.PL.Employe
{
    partial class ProductEditView
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            tbx_Name = new TextBox();
            tbx_Description = new TextBox();
            tbx_Price = new TextBox();
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            button3 = new Button();
            button4 = new Button();
            lb_erosign = new Label();
            label6 = new Label();
            label7 = new Label();
            button5 = new Button();
            tbx_NewCategorie = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(359, 728);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Sichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(753, 68);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(855, 233);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 2;
            label2.Text = "Beschreibung";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(847, 368);
            label3.Name = "label3";
            label3.Size = new Size(49, 25);
            label3.TabIndex = 3;
            label3.Text = "Preis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(846, 487);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 4;
            label4.Text = "Kategorien";
            // 
            // button2
            // 
            button2.Location = new Point(525, 728);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tbx_Name
            // 
            tbx_Name.Location = new Point(764, 113);
            tbx_Name.Name = "tbx_Name";
            tbx_Name.Size = new Size(150, 31);
            tbx_Name.TabIndex = 6;
            // 
            // tbx_Description
            // 
            tbx_Description.Location = new Point(847, 276);
            tbx_Description.Name = "tbx_Description";
            tbx_Description.Size = new Size(643, 31);
            tbx_Description.TabIndex = 7;
            // 
            // tbx_Price
            // 
            tbx_Price.Location = new Point(847, 436);
            tbx_Price.Name = "tbx_Price";
            tbx_Price.Size = new Size(150, 31);
            tbx_Price.TabIndex = 8;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(807, 551);
            listBox1.Name = "listBox1";
            listBox1.SelectionMode = SelectionMode.MultiExtended;
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 9;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(1152, 551);
            listBox2.Name = "listBox2";
            listBox2.SelectionMode = SelectionMode.MultiExtended;
            listBox2.Size = new Size(180, 129);
            listBox2.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(97, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(559, 551);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Red;
            label5.Location = new Point(294, 675);
            label5.Name = "label5";
            label5.Size = new Size(50, 25);
            label5.TabIndex = 12;
            label5.Text = "error";
            // 
            // button3
            // 
            button3.Location = new Point(847, 686);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 13;
            button3.Text = "remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(1192, 686);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 14;
            button4.Text = "add";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // lb_erosign
            // 
            lb_erosign.AutoSize = true;
            lb_erosign.ForeColor = SystemColors.ControlText;
            lb_erosign.Location = new Point(1000, 436);
            lb_erosign.Margin = new Padding(2, 0, 2, 0);
            lb_erosign.Name = "lb_erosign";
            lb_erosign.Size = new Size(22, 25);
            lb_erosign.TabIndex = 15;
            lb_erosign.Text = "€";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(814, 520);
            label6.Name = "label6";
            label6.Size = new Size(151, 25);
            label6.TabIndex = 16;
            label6.Text = "Aktuelles Produkt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1161, 522);
            label7.Name = "label7";
            label7.Size = new Size(63, 25);
            label7.TabIndex = 17;
            label7.Text = "Global";
            // 
            // button5
            // 
            button5.Location = new Point(1403, 602);
            button5.Name = "button5";
            button5.Size = new Size(112, 34);
            button5.TabIndex = 18;
            button5.Text = "neu";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // tbx_NewCategorie
            // 
            tbx_NewCategorie.Location = new Point(1384, 551);
            tbx_NewCategorie.Name = "tbx_NewCategorie";
            tbx_NewCategorie.Size = new Size(150, 31);
            tbx_NewCategorie.TabIndex = 19;
            // 
            // ProductEditView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbx_NewCategorie);
            Controls.Add(button5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lb_erosign);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Controls.Add(tbx_Price);
            Controls.Add(tbx_Description);
            Controls.Add(tbx_Name);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ProductEditView";
            Size = new Size(1661, 823);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private ListBox listBox1;
        private ListBox listBox2;
        private PictureBox pictureBox1;
        private Label label5;
        private Button button3;
        private Button button4;
        private Label lb_erosign;
        private Label label6;
        private Label label7;
        private Button button5;
        private TextBox tbx_Name;
        private TextBox tbx_Description;
        private TextBox tbx_Price;
        private TextBox tbx_NewCategorie;
    }
}
