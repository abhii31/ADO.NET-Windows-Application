namespace Institute_Proj
{
    partial class frmlogin
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
            this.lblun = new System.Windows.Forms.Label();
            this.lblpsw = new System.Windows.Forms.Label();
            this.txtun = new System.Windows.Forms.TextBox();
            this.txtpsw = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnlogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblun
            // 
            this.lblun.AutoSize = true;
            this.lblun.BackColor = System.Drawing.Color.White;
            this.lblun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblun.ForeColor = System.Drawing.Color.Maroon;
            this.lblun.Location = new System.Drawing.Point(89, 73);
            this.lblun.Name = "lblun";
            this.lblun.Size = new System.Drawing.Size(137, 29);
            this.lblun.TabIndex = 0;
            this.lblun.Text = "UserName";
            // 
            // lblpsw
            // 
            this.lblpsw.AutoSize = true;
            this.lblpsw.BackColor = System.Drawing.Color.White;
            this.lblpsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpsw.ForeColor = System.Drawing.Color.Maroon;
            this.lblpsw.Location = new System.Drawing.Point(89, 169);
            this.lblpsw.Name = "lblpsw";
            this.lblpsw.Size = new System.Drawing.Size(132, 29);
            this.lblpsw.TabIndex = 1;
            this.lblpsw.Text = "PassWord";
            // 
            // txtun
            // 
            this.txtun.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtun.Location = new System.Drawing.Point(397, 70);
            this.txtun.Multiline = true;
            this.txtun.Name = "txtun";
            this.txtun.Size = new System.Drawing.Size(200, 30);
            this.txtun.TabIndex = 2;
            // 
            // txtpsw
            // 
            this.txtpsw.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpsw.Location = new System.Drawing.Point(397, 166);
            this.txtpsw.Multiline = true;
            this.txtpsw.Name = "txtpsw";
            this.txtpsw.PasswordChar = '*';
            this.txtpsw.Size = new System.Drawing.Size(200, 30);
            this.txtpsw.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(413, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnlogin.Font = new System.Drawing.Font("Mongolian Baiti", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Blue;
            this.btnlogin.Location = new System.Drawing.Point(94, 278);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(170, 50);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // frmlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(682, 392);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtpsw);
            this.Controls.Add(this.txtun);
            this.Controls.Add(this.lblpsw);
            this.Controls.Add(this.lblun);
            this.Name = "frmlogin";
            this.Text = "frmlogin";
            this.Load += new System.EventHandler(this.frmlogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblun;
        private System.Windows.Forms.Label lblpsw;
        private System.Windows.Forms.TextBox txtun;
        private System.Windows.Forms.TextBox txtpsw;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnlogin;
    }
}

