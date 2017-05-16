using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlyByNightBank.Web.Models;

namespace FlyByNightBank.Web.DAL
{
    public class UserFakeDAL : IUserDAL
    {
        private static Dictionary<string, User> userDictionary = new Dictionary<string, User>();

        public User LoginUser(string username, string password)
        {
            if (userDictionary.ContainsKey(username))
            {
                User user = userDictionary[username];
                if (user.Password == password)
                {
                    return user;
                }
            }

            return null;
        }

        public bool SaveUser(User user)
        {
            if (!userDictionary.ContainsKey(user.Email))
            {
                userDictionary.Add(user.Email, user);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}