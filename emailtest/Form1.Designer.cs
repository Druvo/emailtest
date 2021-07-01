namespace emailtest
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.host = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.TextBox();
            this.message = new System.Windows.Forms.TextBox();
            this.subject = new System.Windows.Forms.TextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // host
            // 
            this.host.Location = new System.Drawing.Point(221, 84);
            this.host.Margin = new System.Windows.Forms.Padding(4);
            this.host.Name = "host";
            this.host.Size = new System.Drawing.Size(251, 22);
            this.host.TabIndex = 0;
            this.host.Text = "smtp.gmail.com";
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(221, 116);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(251, 22);
            this.username.TabIndex = 2;
            this.username.Text = "bloodlagbebd@gmail.com";
            // 
            // port
            // 
            this.port.Location = new System.Drawing.Point(221, 180);
            this.port.Margin = new System.Windows.Forms.Padding(4);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(251, 22);
            this.port.TabIndex = 6;
            this.port.Text = "587";
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(221, 148);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(251, 22);
            this.password.TabIndex = 4;
            this.password.Text = "bloodlagbe321";
            // 
            // to
            // 
            this.to.Location = new System.Drawing.Point(221, 212);
            this.to.Margin = new System.Windows.Forms.Padding(4);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(251, 22);
            this.to.TabIndex = 8;
            this.to.Text = "zhdruvo@gmail.com";
            // 
            // message
            // 
            this.message.Location = new System.Drawing.Point(221, 276);
            this.message.Margin = new System.Windows.Forms.Padding(4);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(251, 22);
            this.message.TabIndex = 11;
            this.message.Text = "TEST from code";
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(221, 244);
            this.subject.Margin = new System.Windows.Forms.Padding(4);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(251, 22);
            this.subject.TabIndex = 13;
            this.subject.Text = "TEST MSG";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(121, 278);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 20);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Message";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(131, 246);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(54, 20);
            this.metroLabel2.TabIndex = 16;
            this.metroLabel2.Text = "Subject";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(155, 214);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(27, 20);
            this.metroLabel3.TabIndex = 17;
            this.metroLabel3.Text = "TO";
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(113, 182);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(69, 20);
            this.metroLabel4.TabIndex = 18;
            this.metroLabel4.Text = "SMTPPort";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(84, 150);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(101, 20);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "SMTPPassword";
            this.metroLabel5.Click += new System.EventHandler(this.metroLabel5_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(74, 118);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(111, 20);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "SMTPUserName";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(113, 86);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(72, 20);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "SMTPHost";
            // 
            // metroTile1
            // 
            this.metroTile1.Location = new System.Drawing.Point(394, 319);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(78, 31);
            this.metroTile1.TabIndex = 22;
            this.metroTile1.Text = "Send";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.metroTile1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 396);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.message);
            this.Controls.Add(this.to);
            this.Controls.Add(this.port);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.host);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Email Test";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox host;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox port;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox to;
        private System.Windows.Forms.TextBox message;
        private System.Windows.Forms.TextBox subject;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

