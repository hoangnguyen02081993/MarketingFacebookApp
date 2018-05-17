using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Models
{
    public class Comment
    {
        private string _Id;
        public string Id {
            set
            {
                _Id = value;
                PostId = _Id.Split('_')[0];
            }
            get
            {
                return _Id;
            }
        }
        public string CreatedTime { set; get; }
        public string PostId { private set; get; }
        public string Message { set; get; }
    }
}
