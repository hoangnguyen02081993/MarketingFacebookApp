using MarketingFacebookApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Services
{
    public class FacebookAPIService
    {
        public User User { set; get; }
        public bool IsLoginSuccess { set; get; }
        public FacebookAPIService(User User)
        {
            this.User = User;
            IsLoginSuccess = false;
        }
        //public User Login()
        //{
        //    string URL = string.Format(https://www.facebook.com/v3.0/dialog/oauth?client_id={app-id}&redirect_uri={redirect-uri}&state={state-param})
        //}

        private static void ConnectSSL(string url)
        {

            //WebRequest request = WebRequest.Create("https://" + sslServerHost + ":" + sslServerPort);
            WebRequest request = WebRequest.Create(url);
            request.Proxy = null;
            request.Credentials = CredentialCache.DefaultCredentials;

            //allows for validation of SSL certificates 

            ServicePointManager.ServerCertificateValidationCallback += new System.Net.Security.RemoteCertificateValidationCallback(ValidateServerCertificate);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();

        }
        private static bool ValidateServerCertificate(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
    }
}
