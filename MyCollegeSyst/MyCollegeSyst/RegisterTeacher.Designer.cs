namespace MyCollegeSyst
{
    partial class RegTeacher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegTeacher));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTeaTaught = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTeaSalary = new System.Windows.Forms.TextBox();
            this.lblRemarks = new System.Windows.Forms.Label();
            this.btnAddTea = new System.Windows.Forms.Button();
            this.btnTeaDisplay = new System.Windows.Forms.Button();
            this.listBox1Teacher = new System.Windows.Forms.ListBox();
            this.txtTeaName = new System.Windows.Forms.TextBox();
            this.txtTeaEmail = new System.Windows.Forms.TextBox();
            this.txtTeaPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 292);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTeaTaught);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTeaSalary);
            this.groupBox1.Controls.Add(this.lblRemarks);
            this.groupBox1.Controls.Add(this.btnAddTea);
            this.groupBox1.Controls.Add(this.btnTeaDisplay);
            this.groupBox1.Controls.Add(this.listBox1Teacher);
            this.groupBox1.Controls.Add(this.txtTeaName);
            this.groupBox1.Controls.Add(this.txtTeaEmail);
            this.groupBox1.Controls.Add(this.txtTeaPhone);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(142, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 570);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teacher";
            // 
            // txtTeaTaught
            // 
            this.txtTeaTaught.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeaTaught.Location = new System.Drawing.Point(121, 189);
            this.txtTeaTaught.Name = "txtTeaTaught";
            this.txtTeaTaught.Size = new System.Drawing.Size(381, 22);
            this.txtTeaTaught.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Taught";
            // 
            // txtTeaSalary
            // 
            this.txtTeaSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeaSalary.Location = new System.Drawing.Point(121, 150);
            this.txtTeaSalary.Name = "txtTeaSalary";
            this.txtTeaSalary.Size = new System.Drawing.Size(381, 22);
            this.txtTeaSalary.TabIndex = 4;
            // 
            // lblRemarks
            // 
            this.lblRemarks.BackColor = System.Drawing.Color.LightGray;
            this.lblRemarks.Location = new System.Drawing.Point(34, 264);
            this.lblRemarks.Name = "lblRemarks";
            this.lblRemarks.Size = new System.Drawing.Size(468, 23);
            this.lblRemarks.TabIndex = 26;
            this.lblRemarks.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddTea
            // 
            this.btnAddTea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTea.Location = new System.Drawing.Point(299, 230);
            this.btnAddTea.Name = "btnAddTea";
            this.btnAddTea.Size = new System.Drawing.Size(94, 23);
            this.btnAddTea.TabIndex = 6;
            this.btnAddTea.Text = "Add";
            this.btnAddTea.UseVisualStyleBackColor = true;
            this.btnAddTea.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // btnTeaDisplay
            // 
            this.btnTeaDisplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeaDisplay.Location = new System.Drawing.Point(408, 230);
            this.btnTeaDisplay.Name = "btnTeaDisplay";
            this.btnTeaDisplay.Size = new System.Drawing.Size(94, 23);
            this.btnTeaDisplay.TabIndex = 7;
            this.btnTeaDisplay.Text = "Display";
            this.btnTeaDisplay.UseVisualStyleBackColor = true;
            this.btnTeaDisplay.Click += new System.EventHandler(this.btnTeaDisplay_Click_1);
            // 
            // listBox1Teacher
            // 
            this.listBox1Teacher.FormattingEnabled = true;
            this.listBox1Teacher.ItemHeight = 16;
            this.listBox1Teacher.Location = new System.Drawing.Point(34, 299);
            this.listBox1Teacher.Name = "listBox1Teacher";
            this.listBox1Teacher.Size = new System.Drawing.Size(468, 260);
            this.listBox1Teacher.TabIndex = 23;
            // 
            // txtTeaName
            // 
            this.txtTeaName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeaName.Location = new System.Drawing.Point(121, 34);
            this.txtTeaName.Name = "txtTeaName";
            this.txtTeaName.Size = new System.Drawing.Size(381, 22);
            this.txtTeaName.TabIndex = 1;
            // 
            // txtTeaEmail
            // 
            this.txtTeaEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeaEmail.Location = new System.Drawing.Point(121, 109);
            this.txtTeaEmail.Name = "txtTeaEmail";
            this.txtTeaEmail.Size = new System.Drawing.Size(381, 22);
            this.txtTeaEmail.TabIndex = 3;
            // 
            // txtTeaPhone
            // 
            this.txtTeaPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeaPhone.Location = new System.Drawing.Point(121, 72);
            this.txtTeaPhone.Name = "txtTeaPhone";
            this.txtTeaPhone.Size = new System.Drawing.Size(381, 22);
            this.txtTeaPhone.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // RegTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 594);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RegTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Teacher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemarks;
        private System.Windows.Forms.Button btnAddTea;
        private System.Windows.Forms.Button btnTeaDisplay;
        private System.Windows.Forms.ListBox listBox1Teacher;
        private System.Windows.Forms.TextBox txtTeaName;
        private System.Windows.Forms.TextBox txtTeaEmail;
        private System.Windows.Forms.TextBox txtTeaPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTeaTaught;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTeaSalary;
    }
}