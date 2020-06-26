using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using TpModule4.Entities;
using TpModule4.Models;
using TpModule4.Services;
using Xamarin.Forms;

[assembly: Dependency(typeof(TwitterService))]
namespace TpModule4.Services
{
    public class TwitterService : ITwitterService
    {
        List<User> users = new List<User>();

        public ObservableCollection<Tweet> Tweets
        {
            get
            {
                users.Add(new User(0, "Dude", "realLebowski", "dudeAndHisCarpet@gmail.com", "dudeWith2D_")); ;
                users.Add(new User(1, "Walter - Jesus Crusher", "walterTheBowler", "professionnalbowlingWalter@orange.fr", "assholeKiller"));
                return new ObservableCollection<Tweet>() {
                    new Tweet()
                    {
                        User = users[0],
                        Content = "Obviously you’re not a golfer",
                        Date = DateTime.Now.ToString()
                    },
                    new Tweet(){
                        User = users[0],
                        Content = "Yeah, I mean that's your Opinion man.",
                        Date = DateTime.Now.ToString()
                    },
                    new Tweet(){
                        User = users[0],
                        Content = "The Dude abides.",
                        Date = DateTime.Now.ToString()
                    },new Tweet(){
                        User = users[1],
                        Content = "Donny, you're out of your element!",
                        Date = DateTime.Now.ToString()
                    },new Tweet(){
                        User = users[1],
                        Content = "This is not ‘Nam. This is bowling. There are rules.",
                        Date = DateTime.Now.ToString()
                    },new Tweet(){
                        User = users[1],
                        Content = "F*ck it, Dude. Let’s go bowling.",
                        Date = DateTime.Now.ToString()
                    }
            };
            }

        }

        public bool authenticate(string login, string password)
        {
            return Tweets.Select(x => x.User).Any(x => x.Login == login && x.Password == password);
        }

        public ObservableCollection<Tweet> getUserTweets(int id)
        {

            return Tweets.Where(x => x.User.Id == id) as ObservableCollection<Tweet>;
        }
    }
}
