using MarketingFacebookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Helpers
{
    public abstract class DBHelper
    {
        public DBType Type { protected set; get; }
        public abstract bool Save();
        public abstract bool ReadData();
        public abstract IEnumerable<User> GetUsers();
        public abstract IEnumerable<FanpageOrGroupFB> GetFanpageOrGroups();
        public abstract bool UserAction(User User, ActionType type = ActionType.Add);
        public abstract bool FanpageOrGroupFBAction(FanpageOrGroupFB User, ActionType type = ActionType.Add);
    }
    public enum DBType
    {
        Xml,
        Json,
        SQLServer
    };
    public enum ActionType
    {
        Add,
        Edit,
        Remove
    }
}
