namespace lms4
{
    partial class return_bk
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
            this.txtbookID = new System.Windows.Forms.TextBox();
            this.txtborrowID = new System.Windows.Forms.TextBox();
            this.buttonEcllipse5 = new lms4.ButtonEcllipse();
            this.btnCancel = new lms4.ButtonEcllipse();
            this.btnNew = new lms4.ButtonEcllipse();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dt_return);
            this.groupBox1.Controls.Add(this.txtbookID);
            this.groupBox1.Controls.Add(this.txtborrowID);
            this.groupBox1.Controls.Add(this.buttonEcllipse5);
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnNew);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 179);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "borrow";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dt_return
            // 
            this.dt_return.Location = new System.Drawing.Point(116, 86);
            this.dt_return.Name = "dt_return";
            this.dt_return.Size = new System.Drawing.Size(178, 27);
            this.dt_return.TabIndex = 58;
            // 
            // txtbookID
            // 
            this.txtbookID.Location = new System.Drawing.Point(116, 53);
            this.txtbookID.Name = "txtbookID";
            this.txtbookID.Size = new System.Drawing.Size(178, 27);
            this.txtbookID.TabIndex = 56;
            // 
            // txtborrowID
            // 
            this.txtborrowID.Location = new System.Drawing.Point(116, 20);
            this.txtborrowID.Name = "txtborrowID";
            this.txtborrowID.Size = new System.Drawing.Size(178, 27);
            this.txtborrowID.TabIndex = 55;
            // 
            // buttonEcllipse5
            // 
            this.buttonEcllipse5.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonEcllipse5.FlatAppearance.BorderSize = 0;
            this.buttonEcllipse5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEcllipse5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEcllipse5.Location = new System.Drawing.Point(157, 119);
            this.buttonEcllipse5.Name = "buttonEcllipse5";
            this.buttonEcllipse5.Size = new System.Drawing.Size(75, 39);
            this.buttonEcllipse5.TabIndex = 54;
            this.buttonEcllipse5.Text = "save";
            this.buttonEcllipse5.UseVisualStyleBackColor = false;
            this.buttonEcllipse5.Click += new System.EventHandler(this.buttonEcllipse3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancel.Location = new System.Drawing.Point(238, 119);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 39);
            this.btnCancel.TabIndex = 53;
            this.btnCancel.Text = "exit";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.buttonEcllipse2_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNew.Location = new System.Drawing.Point(76, 119);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 39);
            this.btnNew.TabIndex = 52;
            this.btnNew.Text = "new";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.buttonEcllipse1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Return Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "borrower ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            // 
            // return_bk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(343, 208);
            this.Controls.Add(this.groupBox1);
            this.Name = "return_bk";
            this.Text = "return_bk";
            this.Load += new System.EventHandler(this.return_bk_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dt_return;
        private System.Windows.Forms.TextBox txtbookID;
        private System.Windows.Forms.TextBox txtborrowID;
        private ButtonEcllipse btnCancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ButtonEcllipse buttonEcllipse5;
        private ButtonEcllipse btnNew;

    }
}