using MarketingFacebookApp.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketingFacebookApp.Extentions;
using MarketingFacebookApp.Helpers;

namespace MarketingFacebookApp.Extentions
{
    public class WebBrowserFacebook : WebBrowser
    {
        public delegate void GetTockenSuccess(object sender, User user);
        public event GetTockenSuccess OnGetTockenSuccess;
        private const string redirect_uri = "https://www.facebook.com/connect/login_success.html";
        private const string _ExtendedPermissions = "public_profile,email,pages_show_list";
        private string client_id;
        private string client_secret;
        Facebook.FacebookClient fb = new Facebook.FacebookClient();
        public WebBrowserFacebook(string client_id, string client_secret) : base()
        {
            this.client_id = client_id;
            this.client_secret = client_secret;

            this.Dock = DockStyle.Fill;

            this.Navigated += WebBrowserFacebook_Navigated;
        }

        public void Login()
        {
            dynamic parameters = new ExpandoObject();
            parameters.client_id = client_id;
            parameters.redirect_uri = redirect_uri;
            parameters.response_type = "token";
            parameters.display = "popup";

            if (!string.IsNullOrEmpty(_ExtendedPermissions))
                parameters.scope = _ExtendedPermissions;

            Uri login_uri = fb.GetLoginUrl(parameters);
            this.Navigate(login_uri.AbsoluteUri);
        }

        private void WebBrowserFacebook_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            int index = e.Url.AbsoluteUri.IndexOf(redirect_uri);
            if (index > -1)
            {
                var Data = e.Url.Fragment.Substring(1).Split('&');
                var user = new User();
                foreach (var item in Data)
                {
                    if(item.Split('=')[0].Equals("access_token"))
                    {
                        user.AccessToken = item.Split('=')[1];
                    }
                    else if(item.Split('=')[0].Equals("expires_in"))
                    {
                        user.ExpiresIn = item.Split('=')[1];
                    }
                }
                this.Parent.Hide();
                user = fb.GetInfo(user);
                OnGetTockenSuccess?.Invoke(this, user);
            }
        }
    }
}
