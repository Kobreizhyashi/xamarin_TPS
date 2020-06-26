using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TpModule4.Entities;
using TpModule4.Models;

namespace TpModule4.Services
{
    public interface ITwitterService
    {

        Boolean authenticate(String login, String password);

        ObservableCollection<Tweet> getUserTweets(int id);

    }
}
