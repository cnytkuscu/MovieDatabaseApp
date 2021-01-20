
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieDatabaseApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();


            System.Threading.Thread.Sleep(3000);

            Navigation.PushAsync(new WelcomePage());
        }
    }
}