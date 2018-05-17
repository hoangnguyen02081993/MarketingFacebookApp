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
                JsonObject info = client.Get("/me?fields=id,name,picture", new
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
                        user.Id = item.Value as string;
                    }
                    if(item.Key.Equals("picture"))
                    {
                        user.PathImage = ((item.Value as JsonObject)
                                        .Where(k => k.Key == "data").FirstOrDefault().Value as JsonObject)
                                        .Where(k => k.Key == "url").FirstOrDefault().Value as string;
                    }
                }
            }
            var pagetoken = client.GetPageToken("nonewa2017", user.AccessToken);
            var listcmd = client.GetCommentsByPostId("1658692860924904", user.AccessToken);
            var lstusers = client.GetListUserInfoByComment(listcmd, user.AccessToken);
            return user;
        }
        public static IEnumerable<Comment> GetCommentsByPostId(this FacebookClient client, string postID, string accesstoken)
        {
            List<Comment> comments = new List<Comment>();
            if (!string.IsNullOrEmpty(accesstoken))
            {
                JsonObject info = client.Get("v2.1/" + postID + "/comments", new
                {
                    access_token = accesstoken
                }) as JsonObject;
                foreach (var item in info)
                {
                    if (item.Key.Equals("data"))
                    {
                        foreach (var comment in item.Value as IEnumerable<dynamic>)
                        {
                            Comment cmt = new Comment()
                            {
                                CreatedTime = comment.created_time,
                                Id = comment.id,
                                Message = comment.message
                            };
                            comments.Add(cmt);
                        }
                        break;
                    }
                }
            }
            return comments;
        }
        public static IEnumerable<User> GetListUserInfoByComment(this FacebookClient client, IEnumerable<Comment> comments, string accesstoken)
        {
            List<User> users = new List<User>();
            if (!string.IsNullOrEmpty(accesstoken))
            {
                foreach (var comment in comments)
                {
                    JsonObject info = client.Get("/" + comment.Id + "?fields=message_tags", new
                    {
                        access_token = accesstoken
                    }) as JsonObject;
                    User user = new User();
                    foreach (var item in info)
                    {
                        if (item.Key.Equals("name"))
                        {
                            user.FullName = item.Value.ToString();
                        }
                        if (item.Key.Equals("id"))
                        {
                            user.Id = item.Value as string;
                        }
                        if (item.Key.Equals("picture"))
                        {
                            user.PathImage = ((item.Value as JsonObject)
                                            .Where(k => k.Key == "data").FirstOrDefault().Value as JsonObject)
                                            .Where(k => k.Key == "url").FirstOrDefault().Value as string;
                        }
                    }
                    users.Add(user);
                }
            }
            return users;
        }
        public static string GetPageToken(this FacebookClient client, string pageid, string accesstoken)
        {
            if (!string.IsNullOrEmpty(accesstoken))
            {
                JsonObject info = client.Get("/" + pageid + "?fields=access_token", new
                {
                    access_token = accesstoken
                }) as JsonObject;
                foreach (var item in info)
                {
                    if (item.Key.Equals("access_token"))
                    {
                        return item.Value as string;
                    }
                }
            }
            return string.Empty;
        }

    }
}
