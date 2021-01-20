using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MovieDatabaseApp.Config
{
  public  static class AppData
    {
        public static string API_Key = "e983423b";
        public static string searchUrlBase = "http://www.omdbapi.com/?apikey=";
        public static string searchUriBottom = "&t=";

        //www.omdbapi.com/?apikey=e983423b&t=fast+and+furious

        public static bool ThemeChoice = false; // means Light Theme



    }
}
