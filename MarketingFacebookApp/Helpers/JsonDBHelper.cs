using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarketingFacebookApp.Models;
using Newtonsoft.Json;

namespace MarketingFacebookApp.Helpers
{
    public class JsonDBHelper : DBHelper
    {
        private const string PathFileName = "./data.dat";

        public Data Data { private set; get; }
        public bool IsOpenSuccess { private set; get; }
        public JsonDBHelper(bool IsAutoOpen = true)
        {
            Type = DBType.Json;
            Data = new Data();
            IsOpenSuccess = false;
            if(IsAutoOpen)
            {
                ReadData();
            }
        }
        public override bool Save()
        {
            try
            {
                string DataSave = JsonConvert.SerializeObject(Data).StringEndcoder();
                File.WriteAllText(PathFileName, DataSave);
                return true;
            }
            catch (Exception ex)
            {
                ex.StackTrace.WriteLog();
                return false;
            }
        }
        public override bool ReadData()
        {
            if (!IsOpenSuccess)
            {
                if (File.Exists(PathFileName))
                {
                    try
                    {
                        string DataString = File.ReadAllText(PathFileName).StringDecoder();
                        Data = JsonConvert.DeserializeObject<Data>(DataString);
                        IsOpenSuccess = true;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        File.Delete(PathFileName);
                        ex.StackTrace.WriteLog();
                    }
                }
                else
                {
                    try
                    {
                        string DataSave = JsonConvert.SerializeObject(Data).StringEndcoder();
                        File.WriteAllText(PathFileName, DataSave);
                        IsOpenSuccess = true;
                        return true;
                    }
                    catch (Exception ex)
                    {
                        ex.StackTrace.WriteLog();
                    }
                }
                return false;
            }
            return true;
        }
        public override IEnumerable<User> GetUsers()
        {
            return Data.Users;
        }
        public override IEnumerable<FanpageOrGroupFB> GetFanpageOrGroups()
        {
            return Data.FanOrGroups;
        }
        public override bool UserAction(User User, ActionType type = ActionType.Add)
        {
            if (IsOpenSuccess)
            {
                var user = Data.Users.Where(u => u.Id.Equals(User.Id)).FirstOrDefault();
                switch (type)
                {
                    case ActionType.Add:
                        if (user == null)
                        {
                            Data.Users.Add(User);
                            Save();
                            return true;
                        }
                        return false;
                    case ActionType.Edit:
                        if (user != null)
                        {
                            Data.Users.Remove(user);
                            Data.Users.Add(User);
                            Save();
                            return true;
                        }
                        return false;
                    case ActionType.Remove:
                        if(user != null)
                        {
                            Data.Users.Remove(user);
                            Save();
                        }
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }
        public override bool FanpageOrGroupFBAction(FanpageOrGroupFB FanOrGroup, ActionType type = ActionType.Add)
        {
            if (IsOpenSuccess)
            {
                var fanorgroup = Data.FanOrGroups.Where(f => f.Id.Equals(FanOrGroup.Id)).FirstOrDefault();
                switch (type)
                {
                    case ActionType.Add:
                        if (fanorgroup == null)
                        {
                            Data.FanOrGroups.Add(FanOrGroup);
                            Save();
                            return true;
                        }
                        return false;
                    case ActionType.Edit:
                        if (fanorgroup != null)
                        {
                            Data.FanOrGroups.Remove(fanorgroup);
                            Data.FanOrGroups.Add(FanOrGroup);
                            Save();
                            return true;
                        }
                        return false;
                    case ActionType.Remove:
                        if (fanorgroup != null)
                        {
                            Data.FanOrGroups.Remove(fanorgroup);
                            Save();
                        }
                        return true;
                    default:
                        return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
