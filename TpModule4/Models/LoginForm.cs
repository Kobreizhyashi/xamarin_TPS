using System;
using Xamarin.Forms;

namespace TpModule4.Models
{
    public class LoginForm
    {
        private ContentView loginForm;
        private ContentView tweetForm;


        // To complete etc...
       
      public LoginForm(Entry pseudo, Entry password, Switch reminder, ContentView loginForm, ContentView tweetForm)
        {
            this.Login = pseudo;
            this.Password = password;
            this.IsReminded = reminder;
            this.loginForm = loginForm;
            this.tweetForm = tweetForm;
        }

        public Entry Login { get; }

        private MainPage Page { get; set; }

        public Entry Password { get; }

        public Switch IsReminded { get; }

        //public VisibilitySwitch VisibilitySwitch { get; }

        //public ErrorForm Error { get; }

       

        private void Connect_Clicked(object sender, EventArgs e)
        {
            if (Login.Text == null)
            {
               // Error.text = "";
                Console.WriteLine("IHIHIHIHIHIHI");
            }

            if (Password.Text == null)
            {
                Console.WriteLine("OHOHOHOH");
            }

            
        }
    }
}
