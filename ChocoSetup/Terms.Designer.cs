namespace ChocoSetup
{
    partial class Terms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Terms));
            this.AgreeBTN = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeclineBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AgreeBTN
            // 
            this.AgreeBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AgreeBTN.FlatAppearance.BorderSize = 0;
            this.AgreeBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AgreeBTN.ForeColor = System.Drawing.Color.White;
            this.AgreeBTN.Location = new System.Drawing.Point(455, 405);
            this.AgreeBTN.Name = "AgreeBTN";
            this.AgreeBTN.Size = new System.Drawing.Size(118, 43);
            this.AgreeBTN.TabIndex = 0;
            this.AgreeBTN.Text = "Accept";
            this.AgreeBTN.UseVisualStyleBackColor = false;
            this.AgreeBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(17, 74);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(556, 325);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Terms of Service";
            // 
            // DeclineBTN
            // 
            this.DeclineBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DeclineBTN.FlatAppearance.BorderSize = 0;
            this.DeclineBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeclineBTN.ForeColor = System.Drawing.Color.White;
            this.DeclineBTN.Location = new System.Drawing.Point(17, 405);
            this.DeclineBTN.Name = "DeclineBTN";
            this.DeclineBTN.Size = new System.Drawing.Size(118, 43);
            this.DeclineBTN.TabIndex = 3;
            this.DeclineBTN.Text = "Decline";
            this.DeclineBTN.UseVisualStyleBackColor = false;
            this.DeclineBTN.Click += new System.EventHandler(this.DeclineBTN_Click);
            // 
            // Terms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.DeclineBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.AgreeBTN);
            this.Name = "Terms";
            this.Size = new System.Drawing.Size(588, 459);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AgreeBTN;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button DeclineBTN;
    }
}
