using MovieDatabaseApp.Interfaces;
using Xamarin.Forms;

namespace MovieDatabaseApp.Services
{

    class LoginService : ContentPage,ILoginService
    {
        public bool LoginToSystem(string Id, string Pw)
        {
            if(Id == "admin" && Pw == "tyenuc")
            {
                //login granted.
               // Navigation.PushAsync(new LoginPage());
                return true;
            }
            else
            {
                DisplayAlert("Alert", "You've entered wrong Id or Password.", "Try Again");
                return false;
            }
            
        }
    }
}
