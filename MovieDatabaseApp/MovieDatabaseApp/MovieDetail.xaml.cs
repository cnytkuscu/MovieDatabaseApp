using MovieDatabaseApp.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MovieDatabaseApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetail : ContentPage
    {
        MovieModel _movieModel;
        public MovieDetail(MovieModel movieModel)
        {
            InitializeComponent();

            _movieModel = movieModel;
            Show();
            
        }


        private void Show()
        {
            lblMovieName.Text = _movieModel.Title;
            lblRuntime.Text =_movieModel.Runtime;
            lblDirector.Text = _movieModel.Director;
            lblIMDbRating.Text = _movieModel.imdbRating;
        }
    }
}