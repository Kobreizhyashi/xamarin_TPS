using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TpModule4.Models;

namespace TpModule4
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            new LoginForm(this.pseudo, this.password, this.reminder, this.loginForm, this.tweetForm);
        }
        private void Connect_Clicked(object sender, EventArgs e)
        {
            if (this.pseudo.Text == null || this.pseudo.Text.Length < 3)
            {
                errorHandler("Login non valide");
            }
            else if (this.password.Text == null || this.password.Text.Length < 6)
            {
                errorHandler("Password non valide");
            }
            else
            {
                errorHandler(null);
                switchVue();
            }
        }

        private void switchVue()
        {
            this.tweetForm.IsVisible = !this.tweetForm.IsVisible;
            this.loginForm.IsVisible = !this.loginForm.IsVisible;
        }

        private void errorHandler(String errorText)
        {
            if (errorText == null)
            {
                this.error.IsVisible = false;
            }
            else
            {
                this.error.IsVisible = true;
                this.error.Text = "Password non valide";
            }
        }
    }
}
