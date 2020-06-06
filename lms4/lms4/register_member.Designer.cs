namespace lms4
{
    partial class register_member
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
            this.comboselect = new System.Windows.Forms.ComboBox();
            this.txtmemberid = new System.Windows.Forms.TextBox();
            this.lblmember_ID = new System.Windows.Forms.Label();
            this.btnEdit = new lms4.ButtonEcllipse();
            this.btnSave = new lms4.ButtonEcllipse();
            this.btnExit = new lms4.ButtonEcllipse();
            this.btnNew = new lms4.ButtonEcllipse();
            this.dtreg_date = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtpnumber = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.comboselect);
            this.groupBox1.Controls.Add(this.txtmemberid);
            this.groupBox1.Controls.Add(this.lblmember_ID);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.dtreg_date);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtaddress);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtlastname);
            this.groupBox1.Controls.Add(this.txtpnumber);
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txtusername);
            this.groupBox1.Controls.Add(this.txtfirstname);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(263, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 395);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " member";
            // 
            // comboselect
            // 
            this.comboselect.FormattingEnabled = true;
            this.comboselect.Items.AddRange(new object[] {
            "Insert",
            "Edit"});
            this.comboselect.Location = new System.Drawing.Point(15, 26);
            this.comboselect.Name = "comboselect";
            this.comboselect.Size = new System.Drawing.Size(317, 28);
            this.comboselect.TabIndex = 42;
            this.comboselect.SelectedIndexChanged += new System.EventHandler(this.comboselect_SelectedIndexChanged);
            // 
            // txtmemberid
            // 
            this.txtmemberid.Location = new System.Drawing.Point(150, 62);
            this.txtmemberid.Name = "txtmemberid";
            this.txtmemberid.Size = new System.Drawing.Size(182, 27);
            this.txtmemberid.TabIndex = 41;
            this.txtmemberid.TextChanged += new System.EventHandler(this.txtmemberid_TextChanged);
            // 
            // lblmember_ID
            // 
            this.lblmember_ID.AutoSize = true;
            this.lblmember_ID.Location = new System.Drawing.Point(15, 67);
            this.lblmember_ID.Name = "lblmember_ID";
            this.lblmember_ID.Size = new System.Drawing.Size(74, 20);
            this.lblmember_ID.TabIndex = 40;
            this.lblmember_ID.Text = "memberID";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnEdit.Location = new System.Drawing.Point(176, 350);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 39);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnSave.Location = new System.Drawing.Point(95, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnExit.Location = new System.Drawing.Point(273, 350);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 39);
            this.btnExit.TabIndex = 37;
            this.btnExit.Text = "exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNew.Location = new System.Drawing.Point(6, 350);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 39);
            this.btnNew.TabIndex = 36;
            this.btnNew.Text = "new";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // dtreg_date
            // 
            this.dtreg_date.Location = new System.Drawing.Point(150, 307);
            this.dtreg_date.Name = "dtreg_date";
            this.dtreg_date.Size = new System.Drawing.Size(182, 27);
            this.dtreg_date.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 314);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 34;
            this.label8.Text = "Registration date";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(150, 274);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(182, 27);
            this.txtaddress.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "phone number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "lastname";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "first name";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(150, 130);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(182, 27);
            this.txtlastname.TabIndex = 24;
            // 
            // txtpnumber
            // 
            this.txtpnumber.Location = new System.Drawing.Point(150, 241);
            this.txtpnumber.Name = "txtpnumber";
            this.txtpnumber.Size = new System.Drawing.Size(182, 27);
            this.txtpnumber.TabIndex = 23;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(150, 205);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(182, 27);
            this.txtemail.TabIndex = 22;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(150, 168);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(182, 27);
            this.txtusername.TabIndex = 21;
            this.txtusername.TextChanged += new System.EventHandler(this.txtusername_TextChanged);
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(150, 95);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(182, 27);
            this.txtfirstname.TabIndex = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::lms4.Properties.Resources.addmeme;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(245, 395);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // register_member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(629, 419);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "register_member";
            this.Text = "n n n";
            this.Load += new System.EventHandler(this.register_member_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ButtonEcllipse btnEdit;
        private ButtonEcllipse btnSave;
        private ButtonEcllipse btnExit;
        private ButtonEcllipse btnNew;
        private System.Windows.Forms.DateTimePicker dtreg_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtpnumber;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtmemberid;
        private System.Windows.Forms.Label lblmember_ID;
        private System.Windows.Forms.ComboBox comboselect;
    }
}