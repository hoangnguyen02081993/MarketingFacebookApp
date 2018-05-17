using MarketingFacebookApp.Common;
using MarketingFacebookApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketingFacebookApp
{
    public partial class LoginPreview : Form
    {
        public User ResultUser { private set; get; }
        public LoginPreview()
        {
            InitializeComponent();
        }

        private void LoginPreview_Load(object sender, EventArgs e)
        {
            lb_info.Text = "Vui lòng đăng nhập nick facebook mà bạn muốn \r\nđăng nhập trên phần mềm";
            wb_chuanbi.Navigate(Constant.FACEBOOK_URL);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (LoginForm form = new LoginForm())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ResultUser = form.ResultUser;
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
