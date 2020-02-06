using System;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Movie_InterfaceAPI
{
	public partial class MovieInfoTMDB : Form
	{
		private string imdbId, movTitle;

		public MovieInfoTMDB(string _imdbId, string _movTitle)
		{
			InitializeComponent();
			imdbId = _imdbId;
			movTitle = _movTitle;
			this.Text = movTitle; //tt1408430
		}
		private void MovieInfo_Load(object sender, EventArgs e)
		{
			LoadInfo();
		}
		private void LoadInfo()
		{
			using (WebClient wc = new WebClient())
			{
				string url = "https://api.themoviedb.org/3/find/" + imdbId + "?api_key=" + TMDB.api + "&external_source=imdb_id";
				string json = wc.DownloadString(url);
				JavaScriptSerializer oJS = new JavaScriptSerializer();
				TmdbEntity entity_Tmdb2 = oJS.Deserialize<TmdbEntity>(json);

				foreach (var movie in entity_Tmdb2.movie_results)
				{
					PosterPb.ImageLocation = TMDB.posterUrl + movie.poster_path;
					ResultsLb.Items.Add("Title: " + movie.title);
					ResultsLb.Items.Add("Year: " + movie.release_date);
					ResultsLb.Items.Add("Type: " + movie.genres);
					ResultsLb.Items.Add("Runtime: " + movie.runtime);
					ResultsLb.Items.Add("Plot: " + movie.overview);
					ResultsLb.Items.Add("Language: " + movie.spoken_languages);
					ResultsLb.Items.Add("Country: " + movie.production_countries);
					ResultsLb.Items.Add("IMDB ID: " + imdbId);
					ResultsLb.Items.Add("IMDB Rating: " + movie.vote_average);
					ResultsLb.Items.Add("IMDB Votes: " + movie.vote_count);
				}
			}
		}
	}
}
