namespace ChocoSetup
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContinueBTN1 = new System.Windows.Forms.Button();
            this.ExitBTN1 = new System.Windows.Forms.Button();
            this.changelogbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, -27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(487, 163);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(122, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to the Choco Client Installer!";
            // 
            // ContinueBTN1
            // 
            this.ContinueBTN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContinueBTN1.FlatAppearance.BorderSize = 0;
            this.ContinueBTN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ContinueBTN1.ForeColor = System.Drawing.Color.White;
            this.ContinueBTN1.Location = new System.Drawing.Point(455, 403);
            this.ContinueBTN1.Name = "ContinueBTN1";
            this.ContinueBTN1.Size = new System.Drawing.Size(118, 43);
            this.ContinueBTN1.TabIndex = 2;
            this.ContinueBTN1.Text = "Continue";
            this.ContinueBTN1.UseVisualStyleBackColor = false;
            this.ContinueBTN1.Click += new System.EventHandler(this.ContinueBTN1_Click);
            // 
            // ExitBTN1
            // 
            this.ExitBTN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBTN1.FlatAppearance.BorderSize = 0;
            this.ExitBTN1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBTN1.ForeColor = System.Drawing.Color.White;
            this.ExitBTN1.Location = new System.Drawing.Point(16, 403);
            this.ExitBTN1.Name = "ExitBTN1";
            this.ExitBTN1.Size = new System.Drawing.Size(118, 43);
            this.ExitBTN1.TabIndex = 3;
            this.ExitBTN1.Text = "Exit";
            this.ExitBTN1.UseVisualStyleBackColor = false;
            this.ExitBTN1.Click += new System.EventHandler(this.ExitBTN1_Click);
            // 
            // changelogbox
            // 
            this.changelogbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.changelogbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changelogbox.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changelogbox.ForeColor = System.Drawing.Color.White;
            this.changelogbox.Location = new System.Drawing.Point(46, 199);
            this.changelogbox.Name = "changelogbox";
            this.changelogbox.ReadOnly = true;
            this.changelogbox.Size = new System.Drawing.Size(487, 173);
            this.changelogbox.TabIndex = 4;
            this.changelogbox.Text = "Loading...";
            this.changelogbox.TextChanged += new System.EventHandler(this.changelogbox_TextChanged);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.changelogbox);
            this.Controls.Add(this.ExitBTN1);
            this.Controls.Add(this.ContinueBTN1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Welcome";
            this.Size = new System.Drawing.Size(588, 459);
            this.Load += new System.EventHandler(this.Welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ContinueBTN1;
        private System.Windows.Forms.Button ExitBTN1;
        private System.Windows.Forms.RichTextBox changelogbox;
    }
}
