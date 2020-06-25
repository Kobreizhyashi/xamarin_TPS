using System;
using System.Collections.Generic;
using TpModule4.Entities;
using TpModule4.Models;
using TpModule4.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(TwitterService))]
namespace TpModule4.Services
{
    public class TwitterService : ITwitterService
    {
        public TwitterService()
        {
        }

        public bool authenticate(string login, string password)
        {
            if (String.IsNullOrEmpty(login) || String.IsNullOrEmpty(password))
            {
                return false;
            }
            return true;
        }

        public List<Tweet> getTweets(string user)
        {
            List<Tweet> result = new List<Tweet>();
            return result;
        }
    }
}
