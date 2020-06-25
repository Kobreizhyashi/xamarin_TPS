using System;
using System.Collections.Generic;
using TpModule4.Models;

namespace TpModule4.Services
{
    public interface ITwitterService
    {

        Boolean authenticate(String login, String password);

        List<Tweet> getTweets(String user);

    }
}
