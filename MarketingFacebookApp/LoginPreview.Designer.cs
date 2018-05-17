namespace MarketingFacebookApp
{
    partial class LoginPreview
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
            this.wb_chuanbi = new System.Windows.Forms.WebBrowser();
            this.lb_info = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wb_chuanbi
            // 
            this.wb_chuanbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.wb_chuanbi.Location = new System.Drawing.Point(0, 0);
            this.wb_chuanbi.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_chuanbi.Name = "wb_chuanbi";
            this.wb_chuanbi.Size = new System.Drawing.Size(800, 392);
            this.wb_chuanbi.TabIndex = 0;
            // 
            // lb_info
            // 
            this.lb_info.AutoSize = true;
            this.lb_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_info.ForeColor = System.Drawing.Color.Crimson;
            this.lb_info.Location = new System.Drawing.Point(5, 397);
            this.lb_info.Name = "lb_info";
            this.lb_info.Size = new System.Drawing.Size(0, 25);
            this.lb_info.TabIndex = 1;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(713, 415);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Text = "Hủy";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(632, 415);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 2;
            this.btn_next.Text = "Tiếp tục";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // LoginPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lb_info);
            this.Controls.Add(this.wb_chuanbi);
            this.Name = "LoginPreview";
            this.Text = "LoginPreview";
            this.Load += new System.EventHandler(this.LoginPreview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser wb_chuanbi;
        private System.Windows.Forms.Label lb_info;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_next;
    }
}