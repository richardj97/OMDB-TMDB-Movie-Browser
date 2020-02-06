using System;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Movie_InterfaceAPI
{
    public partial class MovieInfo : Form
    {
        private string imdbId;

        public MovieInfo(string imdbId, string movTitle)
        {
            InitializeComponent();
            this.imdbId = imdbId;
            this.Text = movTitle;
        }
        private void MovieInfo_Load(object sender, EventArgs e)
        {
            string url = OMDB.imdbAddress + imdbId + "&apikey=" + OMDB.api;

            using (WebClient wc = new WebClient())
            {
                string json = wc.DownloadString(url);

                JavaScriptSerializer oJS = new JavaScriptSerializer();
                ImdbEntity_S Entity_S = oJS.Deserialize<ImdbEntity_S>(json);
                var movies = oJS.Serialize(Entity_S);

                if (Entity_S.Response == "True")
                {
                    PosterPb.ImageLocation = Entity_S.Poster;
                    ResultsLb.Items.Add("Title: " + Entity_S.Title);
                    ResultsLb.Items.Add("Year: " + Entity_S.Year);
                    ResultsLb.Items.Add("Type: " + Entity_S.Type);
                    ResultsLb.Items.Add("Rated: " + Entity_S.Rated);
                    ResultsLb.Items.Add("Released: " + Entity_S.Released);
                    ResultsLb.Items.Add("Runtime: " + Entity_S.Runtime);
                    ResultsLb.Items.Add("Genre: " + Entity_S.Genre);
                    ResultsLb.Items.Add("Directors: " + Entity_S.Director);
                    ResultsLb.Items.Add("Writer: " + Entity_S.Writer);
                    ResultsLb.Items.Add("Actors: " + Entity_S.Actors);
                    ResultsLb.Items.Add("Plot: " + Entity_S.Plot);
                    ResultsLb.Items.Add("Language: " + Entity_S.Language);
                    ResultsLb.Items.Add("Country: " + Entity_S.Country);
                    ResultsLb.Items.Add("Awards: " + Entity_S.Awards);
                    ResultsLb.Items.Add("Metascore: " + Entity_S.Metascore);
                    ResultsLb.Items.Add("IMDB ID: " + Entity_S.imdbID);
                    ResultsLb.Items.Add("IMDB Rating: " + Entity_S.imdbRating);
                    ResultsLb.Items.Add("IMDB Votes: " + Entity_S.imdbVotes);
                }
                else
                {
                    MessageBox.Show("There was an error requesting movie data", "Error");
                }
            }
        }
    }
}
