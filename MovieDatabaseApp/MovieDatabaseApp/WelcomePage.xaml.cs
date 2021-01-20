using MovieDatabaseApp.Config;
using MovieDatabaseApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieDatabaseApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
        private bool buttonLoginMode = false;
        private void btnLogin_Clicked(object sender, EventArgs e)
        {
           
            if (buttonLoginMode)
            {
                buttonLoginMode = false;
                txtUsername.IsVisible = false;
                System.Threading.Thread.Sleep(250);
                txtPassword.IsVisible = false;
                System.Threading.Thread.Sleep(1000);

                LoginService loginService = new LoginService();
                var result = loginService.LoginToSystem(txtUsername.Text, txtPassword.Text);

                if (result)
                {
                    Navigation.PushAsync(new LoginPage());

                }
                if (!result)
                {
                    txtUsername.Text = string.Empty;
                    txtPassword.Text = string.Empty;
                }



            }
            else
            {
                buttonLoginMode = true;
                txtUsername.IsVisible = true;
                txtPassword.IsVisible = true;
            }
        }

        private void btnSearch_Clicked(object sender, EventArgs e)
        {
            SearchService searchService = new SearchService();
            searchService.GetSearchResult(txtMovieName.Text);
        }

        private void btnFacebook_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.facebook.com"));
        }

        private void btnInstagram_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.instagram.com"));
        }

        private void btnSnapchat_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.snapchat.com"));
        }

        private void btnTwitter_Clicked(object sender, EventArgs e)
        {
            Launcher.OpenAsync(new Uri("https://www.twitter.com"));
        }

        private void btnThemeColor_Clicked(object sender, EventArgs e)
        {
            if (!AppData.ThemeChoice)
                AppData.ThemeChoice = true; // Dark Theme
            else
                AppData.ThemeChoice = false; // Light Theme
        }
    }
}