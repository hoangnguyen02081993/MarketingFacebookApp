using MarketingFacebookApp.Common;
using MarketingFacebookApp.Extentions;
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
    public partial class LoginForm : Form
    {
        private WebBrowserFacebook wbFace = new WebBrowserFacebook(Constant.CLIENT_ID, Constant.CLIENT_SECRET);
        public User ResultUser { set; get; } = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(wbFace);
            wbFace.OnGetTockenSuccess += WbFace_OnGetTockenSuccess;
            wbFace.Login();
        }

        private void WbFace_OnGetTockenSuccess(object sender, Models.User user)
        {
            ResultUser = user;
            DialogResult = DialogResult.OK;
        }
    }
}
