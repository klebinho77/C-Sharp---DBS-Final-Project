namespace MyCollegeSyst
{
    partial class Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tools));
            this.pctBoxNote = new System.Windows.Forms.PictureBox();
            this.ptcBoxWord = new System.Windows.Forms.PictureBox();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxNote)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxWord)).BeginInit();
            this.SuspendLayout();
            // 
            // pctBoxNote
            // 
            this.pctBoxNote.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctBoxNote.Image = ((System.Drawing.Image)(resources.GetObject("pctBoxNote.Image")));
            this.pctBoxNote.Location = new System.Drawing.Point(233, 52);
            this.pctBoxNote.Name = "pctBoxNote";
            this.pctBoxNote.Size = new System.Drawing.Size(127, 136);
            this.pctBoxNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxNote.TabIndex = 1;
            this.pctBoxNote.TabStop = false;
            // 
            // ptcBoxWord
            // 
            this.ptcBoxWord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptcBoxWord.Image = ((System.Drawing.Image)(resources.GetObject("ptcBoxWord.Image")));
            this.ptcBoxWord.Location = new System.Drawing.Point(72, 52);
            this.ptcBoxWord.Name = "ptcBoxWord";
            this.ptcBoxWord.Size = new System.Drawing.Size(127, 136);
            this.ptcBoxWord.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptcBoxWord.TabIndex = 0;
            this.ptcBoxWord.TabStop = false;
            // 
            // btnWord
            // 
            this.btnWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.Location = new System.Drawing.Point(72, 206);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(127, 23);
            this.btnWord.TabIndex = 2;
            this.btnWord.Text = "Word";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.Location = new System.Drawing.Point(233, 206);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(127, 23);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Calculator";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 301);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnWord);
            this.Controls.Add(this.pctBoxNote);
            this.Controls.Add(this.ptcBoxWord);
            this.Name = "Tools";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tools";
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxNote)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptcBoxWord)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptcBoxWord;
        private System.Windows.Forms.PictureBox pctBoxNote;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnCalc;
    }
}