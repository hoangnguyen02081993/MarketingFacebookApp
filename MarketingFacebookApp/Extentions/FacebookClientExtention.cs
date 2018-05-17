using Facebook;
using MarketingFacebookApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketingFacebookApp.Extentions
{
    public static class FacebookClientExtention
    {
        public static User GetInfo(this FacebookClient client, User user)
        {
            if(!string.IsNullOrEmpty(user.AccessToken))
            {
                JsonObject info = client.Get("/me", new
                {
                    access_token = user.AccessToken
                }) as JsonObject;
                foreach (var item in info)
                {
                    if(item.Key.Equals("name"))
                    {
                        user.FullName = item.Value.ToString();
                    }
                    if(item.Key.Equals("id"))
                    {
                        user.Id = item.Value.ToString();
                        JsonObject image = client.Get("/" + user.Id + "?fields=picture", new {
                            access_token = user.AccessToken
                        }) as JsonObject;
                        user.PathImage = ((image.Where(k => k.Key == "picture").FirstOrDefault().Value as JsonObject)
                                         .Where(k => k.Key == "data").FirstOrDefault().Value as JsonObject)
                                         .Where(k => k.Key == "url").FirstOrDefault().Value as string;
                    }
                }
            }
            return user;
        }
    }
}
