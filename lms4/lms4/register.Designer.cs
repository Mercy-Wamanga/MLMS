namespace lms4
{
    partial class register
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbcombo = new System.Windows.Forms.ComboBox();
            this.lbl_status = new System.Windows.Forms.Label();
            this.txtcpword = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonEcllipse2 = new lms4.ButtonEcllipse();
            this.buttonEcllipse1 = new lms4.ButtonEcllipse();
            this.cmbreg_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtpword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlname = new System.Windows.Forms.TextBox();
            this.txtpnumber = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.txtfname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbcombo);
            this.groupBox1.Controls.Add(this.lbl_status);
            this.groupBox1.Controls.Add(this.txtcpword);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.buttonEcllipse2);
            this.groupBox1.Controls.Add(this.buttonEcllipse1);
            this.groupBox1.Controls.Add(this.cmbreg_date);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtpword);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtlname);
            this.groupBox1.Controls.Add(this.txtpnumber);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtuname);
            this.groupBox1.Controls.Add(this.txtfname);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(289, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 415);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "register";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmbcombo
            // 
            this.cmbcombo.FormattingEnabled = true;
            this.cmbcombo.Items.AddRange(new object[] {
            "Deactivated",
            "Activated"});
            this.cmbcombo.Location = new System.Drawing.Point(146, 329);
            this.cmbcombo.Name = "cmbcombo";
            this.cmbcombo.Size = new System.Drawing.Size(182, 28);
            this.cmbcombo.TabIndex = 23;
            this.cmbcombo.SelectedIndexChanged += new System.EventHandler(this.cmbcombo_SelectedIndexChanged);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(14, 329);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(48, 20);
            this.lbl_status.TabIndex = 22;
            this.lbl_status.Text = "Status";
            // 
            // txtcpword
            // 
            this.txtcpword.Location = new System.Drawing.Point(146, 263);
            this.txtcpword.Name = "txtcpword";
            this.txtcpword.Size = new System.Drawing.Size(182, 27);
            this.txtcpword.TabIndex = 21;
            this.txtcpword.UseSystemPasswordChar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "confirm password";
            // 
            // buttonEcllipse2
            // 
            this.buttonEcllipse2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEcllipse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEcllipse2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEcllipse2.Location = new System.Drawing.Point(253, 370);
            this.buttonEcllipse2.Name = "buttonEcllipse2";
            this.buttonEcllipse2.Size = new System.Drawing.Size(75, 39);
            this.buttonEcllipse2.TabIndex = 19;
            this.buttonEcllipse2.Text = "cancel";
            this.buttonEcllipse2.UseVisualStyleBackColor = false;
            this.buttonEcllipse2.Click += new System.EventHandler(this.buttonEcllipse2_Click);
            // 
            // buttonEcllipse1
            // 
            this.buttonEcllipse1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEcllipse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEcllipse1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.buttonEcllipse1.Location = new System.Drawing.Point(146, 370);
            this.buttonEcllipse1.Name = "buttonEcllipse1";
            this.buttonEcllipse1.Size = new System.Drawing.Size(75, 39);
            this.buttonEcllipse1.TabIndex = 18;
            this.buttonEcllipse1.Text = "register";
            this.buttonEcllipse1.UseVisualStyleBackColor = false;
            this.buttonEcllipse1.Click += new System.EventHandler(this.buttonEcllipse1_Click);
            // 
            // cmbreg_date
            // 
            this.cmbreg_date.Location = new System.Drawing.Point(146, 296);
            this.cmbreg_date.Name = "cmbreg_date";
            this.cmbreg_date.Size = new System.Drawing.Size(182, 27);
            this.cmbreg_date.TabIndex = 17;
            this.cmbreg_date.ValueChanged += new System.EventHandler(this.cmbreg_date_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 296);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Registration date";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtpword
            // 
            this.txtpword.Location = new System.Drawing.Point(146, 229);
            this.txtpword.Name = "txtpword";
            this.txtpword.Size = new System.Drawing.Size(182, 27);
            this.txtpword.TabIndex = 13;
            this.txtpword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "password";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(146, 196);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(182, 27);
            this.txtaddress.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "first name";
            // 
            // txtlname
            // 
            this.txtlname.Location = new System.Drawing.Point(146, 57);
            this.txtlname.Name = "txtlname";
            this.txtlname.Size = new System.Drawing.Size(182, 27);
            this.txtlname.TabIndex = 4;
            // 
            // txtpnumber
            // 
            this.txtpnumber.Location = new System.Drawing.Point(146, 163);
            this.txtpnumber.Name = "txtpnumber";
            this.txtpnumber.Size = new System.Drawing.Size(182, 27);
            this.txtpnumber.TabIndex = 3;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(146, 128);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(182, 27);
            this.txtemail.TabIndex = 2;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(146, 92);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(182, 27);
            this.txtuname.TabIndex = 1;
            // 
            // txtfname
            // 
            this.txtfname.Location = new System.Drawing.Point(146, 21);
            this.txtfname.Name = "txtfname";
            this.txtfname.Size = new System.Drawing.Size(182, 27);
            this.txtfname.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::lms4.Properties.Resources.registeri;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 415);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(635, 439);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "register";
            this.Text = "register";
            this.Load += new System.EventHandler(this.register_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtpword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlname;
        private System.Windows.Forms.TextBox txtpnumber;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.TextBox txtfname;
        private System.Windows.Forms.DateTimePicker cmbreg_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ButtonEcllipse buttonEcllipse2;
        private ButtonEcllipse buttonEcllipse1;
        private System.Windows.Forms.TextBox txtcpword;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbcombo;
        private System.Windows.Forms.Label lbl_status;
    }
}