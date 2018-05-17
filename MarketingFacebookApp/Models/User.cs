using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Models
{
    public class User
    {
        public string Id { set; get; }
        public string FullName { set; get; }
        public string PathImage { set; get; }
        public string AccessToken { set; get; }
        public string ExpiresIn { set; get; }
    }
}
