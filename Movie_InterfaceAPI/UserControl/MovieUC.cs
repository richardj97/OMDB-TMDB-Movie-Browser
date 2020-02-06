using System;
using System.Windows.Forms;
using System.Globalization;
using System.Net;
using System.Web.Script.Serialization;

namespace Movie_InterfaceAPI
{
    public partial class MovieUC : UserControl
    {
        private string title;
        private string imdbId;
        private Main Main;

        public MovieUC(string imdbId, string title, string year, string posterUrl, string desc, bool isInWishList, bool isInSeenList, Main Main)
        {
            this.InitializeComponent();
            this.Main = Main;
            this.TitleLb.Text = title + " (" + year + ") " + "\n\nType: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(desc);
            this.PosterPb.ImageLocation = posterUrl;
            this.title = title;
            this.imdbId = imdbId;

            if (isInWishList)
            {
                WishListBtn.Text = "- Wish List";
            }
            else
            {
                WishListBtn.Text = "+ Wish List";
            }

            if (isInSeenList)
            {
                SeenBtn.Image = Properties.Resources.icons8_eye_23_Copy;
            }
            else
            {
                SeenBtn.Image = Properties.Resources.icons8_eye_23;
            }
        }

		private string GetImdbId()
		{
			string url = "https://api.themoviedb.org/3/movie/" + imdbId + "?api_key=" + TMDB.api;

			using (WebClient wc = new WebClient())
			{
				string json = wc.DownloadString(url);

				JavaScriptSerializer oJS = new JavaScriptSerializer();
				TmdbImdb entity_Tmdb = oJS.Deserialize<TmdbImdb>(json);
				var movies = oJS.Serialize(entity_Tmdb);

				if (entity_Tmdb != null)
				{
					imdbId = entity_Tmdb.imdb_id;
				}
				else
				{
					MessageBox.Show("There was an error requesting movie data", "Error");
				}
			}
			return imdbId;
		}

        private void MoreInfoLl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			if (Main.apiSelect == 0)
			{
				MovieInfo MovieInfoFrm = new MovieInfo(imdbId, title);
				MovieInfoFrm.ShowDialog();
			}
			else if (Main.apiSelect == 1)
			{
				MovieInfoTMDB MovieInfoFrm = new MovieInfoTMDB(GetImdbId(), title);
				MovieInfoFrm.ShowDialog();
			}
        }
        private void WishListBtn_Click(object sender, EventArgs e)
        {
			if (Main.apiSelect == 0)
			{
				if (!Main.TitleInWishList(imdbId))
				{
					Main.Entity_S.AddToWishList(imdbId);
					MessageBox.Show(this, title + " has been added to the wish list", "Success");
					WishListBtn.Text = "- Wish List";
				}
				else
				{
					Main.Entity_S.RemoveFromWishList(imdbId);
					MessageBox.Show(this, title + " has been removed to the wish list", "Success");
					WishListBtn.Text = "+ Wish List";
				}
			}
			else if (Main.apiSelect == 1)
			{
				if (!Main.TitleInWishList(GetImdbId()))
				{
					Main.Entity_S.AddToWishList(GetImdbId());
					MessageBox.Show(this, title + " has been added to the wish list", "Success");
					WishListBtn.Text = "- Wish List";
				}
				else
				{
					Main.Entity_S.RemoveFromWishList(GetImdbId());
					MessageBox.Show(this, title + " has been removed to the wish list", "Success");
					WishListBtn.Text = "+ Wish List";
				}
			}
            Main.UpdateResultResult();
        }
        private void SeenBtn_Click(object sender, EventArgs e)
        {
			if (Main.apiSelect == 0)
			{
				if (!Main.TitleInSeenList(imdbId))
				{
					Main.Entity_S.AddToSeenList(imdbId);
					MessageBox.Show(this, title + " has been added to the seen list", "Success");
					SeenBtn.Image = Properties.Resources.icons8_eye_23_Copy;
				}
				else
				{
					Main.Entity_S.RemoveFromSeenList(imdbId);
					MessageBox.Show(this, title + " has been removed from the seen list", "Success");
					SeenBtn.Image = Properties.Resources.icons8_eye_23;
				}
			}
			else if (Main.apiSelect == 1)
			{
				if (!Main.TitleInSeenList(GetImdbId()))
				{
					Main.Entity_S.AddToSeenList(GetImdbId());
					MessageBox.Show(this, title + " has been added to the seen list", "Success");
					SeenBtn.Image = Properties.Resources.icons8_eye_23_Copy;
				}
				else
				{
					Main.Entity_S.RemoveFromSeenList(GetImdbId());
					MessageBox.Show(this, title + " has been removed from the seen list", "Success");
					SeenBtn.Image = Properties.Resources.icons8_eye_23;
				}
			}
            Main.UpdateResultResult();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TitleLb_Click(object sender, EventArgs e)
        {

        }

        private void PosterPb_Click(object sender, EventArgs e)
        {

        }
    }
}
