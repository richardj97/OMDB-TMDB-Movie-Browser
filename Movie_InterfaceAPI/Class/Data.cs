using System.Collections.Generic;

namespace Movie_InterfaceAPI
{
    public class OMDB
    {
        public static readonly string api = "713b8d09";
        public static readonly string multipleAddress = "http://www.omdbapi.com/?s=";
        public static readonly string singleAddress = "http://www.omdbapi.com/?t=";
        public static readonly string imdbAddress = "http://www.omdbapi.com/?i=";
    }
    public class TMDB
    {
        public static readonly string api = "9b06e83b429f9232d130499b71b7c678";
        public static readonly string singleAddress = "https://api.themoviedb.org/3/";
        public static readonly string multipleAddress = "https://api.themoviedb.org/3/";
        public static readonly string tmdbAddress = "https://api.themoviedb.org/3/";
		public static readonly string posterUrl = "https://image.tmdb.org/t/p/w500/";

	}
	public class TmdbImdb
	{
		public string imdb_id { get; set; }
	}
    public class TmdbEntity
    {
        public List<TmdbEntity> results { get; set; }
		public List<TmdbEntity> movie_results { get; set; }
		public string adult { get; set; }
        public string backdrop_path { get; set; }
        public string belongs_to_collection { get; set; }
        public string budget { get; set; }
        public string genres { get; set; }
        public string homepage { get; set; }
        public string id { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public string popularity { get; set; }
        public string poster_path { get; set; }
        public string production_companies { get; set; }
        public string production_countries { get; set; }
        public string release_date { get; set; }
        public string revenue { get; set; }
        public string runtime { get; set; }
        public string spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public string video { get; set; }
        public string vote_average { get; set; }
        public string vote_count { get; set; }

        public void Data()
        {
            //Properties.Settings.Default.WishList.Clear();
            //Properties.Settings.Default.SeenList.Clear();
        }
        public void AddToWishList(string original_title)
        {
            if (!Properties.Settings.Default.WishList.Contains(original_title))
            {
                Properties.Settings.Default.WishList.Add(original_title);
                Properties.Settings.Default.Save();
            }
        }
        public void RemoveFromWishList(string original_title)
        {
            if (Properties.Settings.Default.WishList.Contains(original_title))
            {
                Properties.Settings.Default.WishList.Remove(original_title);
                Properties.Settings.Default.Save();
            }
        }
        public void AddToSeenList(string original_title)
        {
            if (!Properties.Settings.Default.SeenList.Contains(original_title))
            {
                Properties.Settings.Default.SeenList.Add(original_title);
                Properties.Settings.Default.Save();
            }
        }
        public void RemoveFromSeenList(string original_title)
        {
            if (Properties.Settings.Default.SeenList.Contains(original_title))
            {
                Properties.Settings.Default.SeenList.Remove(original_title);
                Properties.Settings.Default.Save();
            }
        }
    }
    public class TmdbEntity_S
    {
        public string adult { get; set; }
        public string backdrop_path { get; set; }
        public string belongs_to_collection { get; set; }
        public string budget { get; set; }
        public string genres { get; set; }
        public string homepage { get; set; }
        public string id { get; set; }
        public string imdb_id { get; set; }
        public string original_language { get; set; }
        public string original_title { get; set; }
        public string overview { get; set; }
        public string popularity { get; set; }
        public string poster_path { get; set; }
        public string production_companies { get; set; }
        public string production_countries { get; set; }
        public string release_date { get; set; }
        public string revenue { get; set; }
        public string runtime { get; set; }
        public string spoken_languages { get; set; }
        public string status { get; set; }
        public string tagline { get; set; }
        public string title { get; set; }
        public string video { get; set; }
        public string vote_average { get; set; }
        public string vote_count { get; set; }
    }
    public class ImdbEntity_M
    {
        public List<ImdbEntity_M> Search { get; set; }
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Response { get; set; }
    }
    public class ImdbEntity_S
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string Rated { get; set; }
        public string Released { get; set; }
        public string Runtime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }
        public string Metascore { get; set; }
        public string imdbRating { get; set; }
        public string imdbVotes { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Response { get; set; }

        public void Data()
        {
            //Properties.Settings.Default.WishList.Clear();
            //Properties.Settings.Default.SeenList.Clear();
        }
        public void AddToWishList(string Title)
        {
            if (!Properties.Settings.Default.WishList.Contains(Title))
            {
                Properties.Settings.Default.WishList.Add(Title);
                Properties.Settings.Default.Save();
            }
        }
        public void RemoveFromWishList(string Title)
        {
            if (Properties.Settings.Default.WishList.Contains(Title))
            {
                Properties.Settings.Default.WishList.Remove(Title);
                Properties.Settings.Default.Save();
            }
        }
        public void AddToSeenList(string Title)
        {
            if (!Properties.Settings.Default.SeenList.Contains(Title))
            {
                Properties.Settings.Default.SeenList.Add(Title);
                Properties.Settings.Default.Save();
            }
        }
        public void RemoveFromSeenList(string Title)
        {
            if (Properties.Settings.Default.SeenList.Contains(Title))
            {
                Properties.Settings.Default.SeenList.Remove(Title);
                Properties.Settings.Default.Save();
            }
        }
    }
}
