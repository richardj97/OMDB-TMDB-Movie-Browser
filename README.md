Program created in C# Window Forms

It uses 2 movie APIs to search for movies. You can add movies into your wish list, seen list and view more info

Change API Keys:

    public class OMDB
    {
        public static readonly string api = "CHANGEME";
        public static readonly string multipleAddress = "http://www.omdbapi.com/?s=";
        public static readonly string singleAddress = "http://www.omdbapi.com/?t=";
        public static readonly string imdbAddress = "http://www.omdbapi.com/?i=";
    }
    public class TMDB
    {
        public static readonly string api = "CHANGEME";
        public static readonly string singleAddress = "https://api.themoviedb.org/3/";
        public static readonly string multipleAddress = "https://api.themoviedb.org/3/";
        public static readonly string tmdbAddress = "https://api.themoviedb.org/3/";
        public static readonly string posterUrl = "https://image.tmdb.org/t/p/w500/";
    }

Authors: Richard Jacobs, Simon West, Alisdair Keay, Diogo Ribeiro and Jason Malcolm
