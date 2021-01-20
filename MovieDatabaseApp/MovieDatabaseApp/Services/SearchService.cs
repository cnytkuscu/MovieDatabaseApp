using MovieDatabaseApp.Config;
using MovieDatabaseApp.DTO;
using MovieDatabaseApp.Interfaces;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using Xamarin.Forms;

namespace MovieDatabaseApp.Services
{
    class SearchService : ContentPage, ISearchService
    {

        MovieModel movieModel;

        public void GetSearchResult(string movieName)
        {
            movieName = AdaptMovieName(movieName);
            try
            {
                string url = AppData.searchUrlBase + AppData.API_Key + AppData.searchUriBottom + movieName;

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    string apiResult = reader.ReadToEnd();
                    BuildModelFromAPIRequest(apiResult);

                    NavigateToMovieDetailPage(movieModel);
                }
            }
            catch (Exception)
            {
                throw;
            }


        }

        private void NavigateToMovieDetailPage(MovieModel movieModel)
        {
            Navigation.PushAsync(new MovieDetail(movieModel));
        }

        private string AdaptMovieName(string movieName)
        {
            return movieName.Replace(" ", "+");
        }

        private void BuildModelFromAPIRequest(string apiResult)
        {
            movieModel = JsonConvert.DeserializeObject<MovieModel>(apiResult);
        }



    }
}
