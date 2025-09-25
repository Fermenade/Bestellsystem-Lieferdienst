using Bestellsystem_Lieferdienst_Client.Server;

namespace Bestellsystem_Lieferdienst_Client.PL
{
    partial class ConnectionLost
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            button1 = new Button();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(307, 370);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(111, 35);
            button1.TabIndex = 0;
            button1.Text = "Connect";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(438, 25);
            label1.TabIndex = 1;
            label1.Text = "Verbindung zu Server konnte nicht hergestellt werden.";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(315, 177);
            textBox2.Margin = new Padding(2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(149, 31);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(328, 140);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 25);
            label2.TabIndex = 4;
            label2.Text = "IP-Adresse";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(315, 249);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 5;
            label3.Text = "Port";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(315, 284);
            numericUpDown1.Margin = new Padding(2);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(176, 31);
            numericUpDown1.TabIndex = 6;
            // 
            // ConnectionLost
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(numericUpDown1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(button1);
            Margin = new Padding(2);
            Name = "ConnectionLost";
            Size = new Size(906, 465);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public void InitializeManualComponent()
        {
            textBox2.Text = Client.client.ip;
            numericUpDown1.Maximum = 65_535;
            numericUpDown1.Value = Client.client.port;
            numericUpDown1.Minimum = 0;
        }

        private Button button1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private NumericUpDown numericUpDown1;
    }
}
