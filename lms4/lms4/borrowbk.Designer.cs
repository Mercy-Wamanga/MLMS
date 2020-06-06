namespace lms4
{
    partial class borrowbk
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
            this.dt_return = new System.Windows.Forms.DateTimePicker();
            this.dt_issue = new System.Windows.Forms.DateTimePicker();
            this.txtbookID = new System.Windows.Forms.TextBox();
            this.txtmember_ID = new System.Windows.Forms.TextBox();
            this.btnSave = new lms4.ButtonEcllipse();
            this.btnClose = new lms4.ButtonEcllipse();
            this.btnNew = new lms4.ButtonEcllipse();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_return);
            this.groupBox1.Controls.Add(this.dt_issue);
            this.groupBox1.Controls.Add(this.txtbookID);
            this.groupBox1.Controls.Add(this.txtmember_ID);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 244);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "borrow";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dt_return
            // 
            this.dt_return.Location = new System.Drawing.Point(122, 134);
            this.dt_return.Name = "dt_return";
            this.dt_return.Size = new System.Drawing.Size(178, 27);
            this.dt_return.TabIndex = 58;
            // 
            // dt_issue
            // 
            this.dt_issue.Location = new System.Drawing.Point(122, 101);
            this.dt_issue.Name = "dt_issue";
            this.dt_issue.Size = new System.Drawing.Size(178, 27);
            this.dt_issue.TabIndex = 57;
            // 
            // txtbookID
            // 
            this.txtbookID.Location = new System.Drawing.Point(122, 68);
            this.txtbookID.Name = "txtbookID";
            this.txtbookID.Size = new System.Drawing.Size(178, 27);
            this.txtbookID.TabIndex = 56;
            // 
            // txtmember_ID
            // 
            this.txtmember_ID.Location = new System.Drawing.Point(122, 35);
            this.txtmember_ID.Name = "txtmember_ID";
            this.txtmember_ID.Size = new System.Drawing.Size(178, 27);
            this.txtmember_ID.TabIndex = 55;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Location = new System.Drawing.Point(157, 187);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 39);
            this.btnSave.TabIndex = 54;
            this.btnSave.Text = "save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnClose.Location = new System.Drawing.Point(238, 187);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 39);
            this.btnClose.TabIndex = 53;
            this.btnClose.Text = "exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNew.Location = new System.Drawing.Point(76, 187);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 39);
            this.btnNew.TabIndex = 52;
            this.btnNew.Text = "new";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Return Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Issue Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "member ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // borrowbk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(342, 264);
            this.Controls.Add(this.groupBox1);
            this.Name = "borrowbk";
            this.Text = "borrowbk";
            this.Load += new System.EventHandler(this.borrowbk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_return;
        private System.Windows.Forms.DateTimePicker dt_issue;
        private System.Windows.Forms.TextBox txtbookID;
        private System.Windows.Forms.TextBox txtmember_ID;
        private ButtonEcllipse btnSave;
        private ButtonEcllipse btnClose;
        private ButtonEcllipse btnNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}