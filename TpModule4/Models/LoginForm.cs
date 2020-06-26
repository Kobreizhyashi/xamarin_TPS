using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Android.Content.Res;
using TpModule4.Services;
using TpModule4.Vue;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace TpModule4.Models
{
    public class LoginForm
    {
        private TwitterService service = new TwitterService();
        private ContentView loginForm;
        private Label errorLabel;
        private Button connection;
        private INavigation navigation;

        public Entry Login { get; }
        public Entry Password { get; }
        public Xamarin.Forms.Switch IsRemind { get; }
        public ErrorForm Error { get; }
        

        public LoginForm(Entry login, Entry password, Xamarin.Forms.Switch isRemind, View loginForm, Label errorLabel, Button button, INavigation navigation)
        {
            this.Login = login;
            this.Password = password;
            this.IsRemind = isRemind;
            this.Error = new ErrorForm(errorLabel);
            button.Clicked += Button_Clicked;
            this.navigation = navigation;
        }

        public LoginForm(Entry login, Entry password, Xamarin.Forms.Switch isRemind, ContentView loginForm, Label errorLabel, Button connection)
        {
            Login = login;
            Password = password;
            IsRemind = isRemind;
            this.loginForm = loginForm;
            this.errorLabel = errorLabel;
            this.connection = connection;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Debug.WriteLine("btn clicked");
            if (this.IsValid())
            {
                this.Error.Hide();
            }
            else
            {
                this.Error.Display();
            }
        }

        public Boolean IsValid()
        {

            Boolean result = true;

            String login = this.Login.Text;
            String password = this.Password.Text;
            Boolean isRemind = this.IsRemind.IsToggled;

            bool haveError = false;
            StringBuilder stringBuilder = new StringBuilder();

            if (String.IsNullOrEmpty(login) || login.Length < 3)
            {
                haveError = true;
                stringBuilder.Append("L'identifiant ne peut pas être null et doit posséder au moins 3 caractères.");
            }

            if (String.IsNullOrEmpty(password) || password.Length < 6)
            {
                if (haveError)
                {
                    stringBuilder.Append("\n");
                }
                haveError = true;
                stringBuilder.Append("Le mot de passe ne peut pas être null et doit posséder au moins 6 caractères.");
            }

            if (!haveError)
            {
                var current = Connectivity.NetworkAccess;

                if (current == NetworkAccess.Internet)
                {
                    haveError = !service.authenticate(this.Login.Text, this.Password.Text);
                    if (haveError)
                    {
                        stringBuilder.Append("Cet identifiant est inconnu.. Ou je ne sais quoi");
                    }
                }
                else
                {
                    haveError = true;
                    stringBuilder.Append("Pas de connexion mon petit ! Achète du forfait ! ");
                }
            }

            if (haveError)
            {
                this.Error.Error = stringBuilder.ToString();
            } else
            {
                navigation.PushAsync(new HomePage());
            }

            result = !haveError;


            return result;
        }
}
}
