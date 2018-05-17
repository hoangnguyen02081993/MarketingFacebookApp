namespace MarketingFacebookApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_user = new System.Windows.Forms.Panel();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.pn_user);
            this.panel1.Controls.Add(this.btn_login);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 397);
            this.panel1.TabIndex = 0;
            // 
            // pn_user
            // 
            this.pn_user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_user.Location = new System.Drawing.Point(0, 36);
            this.pn_user.Name = "pn_user";
            this.pn_user.Size = new System.Drawing.Size(200, 361);
            this.pn_user.TabIndex = 2;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(12, 7);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(172, 23);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Đăng nhập";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.Btn_login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 397);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Marketing Facebook";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel pn_user;
    }
}

