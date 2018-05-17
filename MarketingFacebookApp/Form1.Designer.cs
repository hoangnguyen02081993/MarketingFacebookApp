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
            this.tc_control = new System.Windows.Forms.TabControl();
            this.tp_autoaddfriend = new System.Windows.Forms.TabPage();
            this.tp_addfriend_param_input = new System.Windows.Forms.TextBox();
            this.tp_addfriend_type = new System.Windows.Forms.ComboBox();
            this.tp_addfriend_param_lable = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tp_addfriend_getlist = new System.Windows.Forms.Button();
            this.tp_addfriend_gv_user = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.image = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.tc_control.SuspendLayout();
            this.tp_autoaddfriend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp_addfriend_gv_user)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(200, 513);
            this.panel1.TabIndex = 0;
            // 
            // pn_user
            // 
            this.pn_user.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pn_user.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pn_user.Location = new System.Drawing.Point(0, 36);
            this.pn_user.Name = "pn_user";
            this.pn_user.Size = new System.Drawing.Size(200, 477);
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
            // tc_control
            // 
            this.tc_control.Controls.Add(this.tp_autoaddfriend);
            this.tc_control.Controls.Add(this.tabPage2);
            this.tc_control.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tc_control.Location = new System.Drawing.Point(200, 0);
            this.tc_control.Name = "tc_control";
            this.tc_control.SelectedIndex = 0;
            this.tc_control.Size = new System.Drawing.Size(682, 513);
            this.tc_control.TabIndex = 1;
            // 
            // tp_autoaddfriend
            // 
            this.tp_autoaddfriend.Controls.Add(this.groupBox1);
            this.tp_autoaddfriend.Controls.Add(this.tp_addfriend_gv_user);
            this.tp_autoaddfriend.Controls.Add(this.tp_addfriend_getlist);
            this.tp_autoaddfriend.Controls.Add(this.tp_addfriend_param_input);
            this.tp_autoaddfriend.Controls.Add(this.tp_addfriend_type);
            this.tp_autoaddfriend.Controls.Add(this.tp_addfriend_param_lable);
            this.tp_autoaddfriend.Controls.Add(this.label2);
            this.tp_autoaddfriend.Controls.Add(this.label1);
            this.tp_autoaddfriend.Location = new System.Drawing.Point(4, 22);
            this.tp_autoaddfriend.Name = "tp_autoaddfriend";
            this.tp_autoaddfriend.Padding = new System.Windows.Forms.Padding(3);
            this.tp_autoaddfriend.Size = new System.Drawing.Size(674, 487);
            this.tp_autoaddfriend.TabIndex = 0;
            this.tp_autoaddfriend.Text = "Kết bạn";
            this.tp_autoaddfriend.UseVisualStyleBackColor = true;
            // 
            // tp_addfriend_param_input
            // 
            this.tp_addfriend_param_input.Location = new System.Drawing.Point(171, 85);
            this.tp_addfriend_param_input.Name = "tp_addfriend_param_input";
            this.tp_addfriend_param_input.Size = new System.Drawing.Size(444, 20);
            this.tp_addfriend_param_input.TabIndex = 3;
            // 
            // tp_addfriend_type
            // 
            this.tp_addfriend_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tp_addfriend_type.FormattingEnabled = true;
            this.tp_addfriend_type.Items.AddRange(new object[] {
            "Những người like bài viết.",
            "Những người share bài viết.",
            "Những người comment bài viết.",
            "Những người thích chủ đề ..."});
            this.tp_addfriend_type.Location = new System.Drawing.Point(171, 49);
            this.tp_addfriend_type.Name = "tp_addfriend_type";
            this.tp_addfriend_type.Size = new System.Drawing.Size(444, 21);
            this.tp_addfriend_type.TabIndex = 2;
            this.tp_addfriend_type.SelectedIndexChanged += new System.EventHandler(this.tp_addfriend_type_SelectedIndexChanged);
            // 
            // tp_addfriend_param_lable
            // 
            this.tp_addfriend_param_lable.AutoSize = true;
            this.tp_addfriend_param_lable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp_addfriend_param_lable.Location = new System.Drawing.Point(68, 87);
            this.tp_addfriend_param_lable.Name = "tp_addfriend_param_lable";
            this.tp_addfriend_param_lable.Size = new System.Drawing.Size(40, 16);
            this.tp_addfriend_param_lable.TabIndex = 1;
            this.tp_addfriend_param_lable.Text = "Link:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại kết bạn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức năng tự động kết bạn";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(674, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tp_addfriend_getlist
            // 
            this.tp_addfriend_getlist.Location = new System.Drawing.Point(511, 120);
            this.tp_addfriend_getlist.Name = "tp_addfriend_getlist";
            this.tp_addfriend_getlist.Size = new System.Drawing.Size(104, 23);
            this.tp_addfriend_getlist.TabIndex = 4;
            this.tp_addfriend_getlist.Text = "Lấy danh sách";
            this.tp_addfriend_getlist.UseVisualStyleBackColor = true;
            this.tp_addfriend_getlist.Click += new System.EventHandler(this.tp_addfriend_getlist_Click);
            // 
            // tp_addfriend_gv_user
            // 
            this.tp_addfriend_gv_user.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tp_addfriend_gv_user.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.image});
            this.tp_addfriend_gv_user.Location = new System.Drawing.Point(71, 154);
            this.tp_addfriend_gv_user.Name = "tp_addfriend_gv_user";
            this.tp_addfriend_gv_user.RowHeadersVisible = false;
            this.tp_addfriend_gv_user.Size = new System.Drawing.Size(544, 164);
            this.tp_addfriend_gv_user.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(71, 324);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 155);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tự động kết bạn";
            // 
            // Id
            // 
            this.Id.HeaderText = "uid";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 170;
            // 
            // name
            // 
            this.name.HeaderText = "Họ và Tên";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // image
            // 
            this.image.HeaderText = "Hình ảnh";
            this.image.Name = "image";
            this.image.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 513);
            this.Controls.Add(this.tc_control);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(898, 552);
            this.MinimumSize = new System.Drawing.Size(898, 552);
            this.Name = "Form1";
            this.Text = "Marketing Facebook";
            this.panel1.ResumeLayout(false);
            this.tc_control.ResumeLayout(false);
            this.tp_autoaddfriend.ResumeLayout(false);
            this.tp_autoaddfriend.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tp_addfriend_gv_user)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel pn_user;
        private System.Windows.Forms.TabControl tc_control;
        private System.Windows.Forms.TabPage tp_autoaddfriend;
        private System.Windows.Forms.TextBox tp_addfriend_param_input;
        private System.Windows.Forms.ComboBox tp_addfriend_type;
        private System.Windows.Forms.Label tp_addfriend_param_lable;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button tp_addfriend_getlist;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView tp_addfriend_gv_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewImageColumn image;
    }
}

