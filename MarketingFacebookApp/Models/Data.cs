using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Models
{
    public class Data
    {
        public List<User> Users { set; get; }
        public List<FanpageOrGroupFB> FanOrGroups { set; get; }
        public Data()
        {
            Users = new List<User>();
            FanOrGroups = new List<FanpageOrGroupFB>();
        }
    }
}
