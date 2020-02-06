using System;
using System.Net;
using System.Windows.Forms;
using System.Web.Script.Serialization;
using System.Collections.Generic;

namespace Movie_InterfaceAPI
{
    public partial class Main : Form
    {
        public ImdbEntity_S Entity_S = new ImdbEntity_S();
        public ImdbEntity_M Entity_M = new ImdbEntity_M();
        public TmdbEntity entity_Tmdb = new TmdbEntity();
		public TmdbEntity_S TMDB_entity_S = new TmdbEntity_S();
		public SeenListUC SeenListUserControl;
        public WishListUC WishListUserControl;
		public static int apiSelect = 0;
		private bool isSingle = false;


        public Main()
        {
            if (Properties.Settings.Default.WishList == null)
                Properties.Settings.Default.WishList = new List<string>();
            if (Properties.Settings.Default.SeenList == null)
                Properties.Settings.Default.SeenList = new List<string>();

            Properties.Settings.Default.Save();

            this.InitializeComponent();
			this.comboBox1.SelectedIndex = 0;
        }
        private void SearchTb_Enter(object sender, EventArgs e)
        {
            if (SearchTb.Text == "Search for movie title...")
                SearchTb.Text = string.Empty;
        }
        private void SearchTb_Leave(object sender, EventArgs e)
        {
            if (SearchTb.Text == string.Empty)
                SearchTb.Text = "Search for movie title...";
        }
        public bool TitleInWishList(string imdbId)
        {
            if (Properties.Settings.Default.WishList.Contains(imdbId))
                return true;
            return false;
        }
        public bool TitleInSeenList(string imdbId)
        {
            if (Properties.Settings.Default.SeenList.Contains(imdbId))
                return true;
            return false;
        }
        public int TitlesWished()
        {
            return Properties.Settings.Default.WishList.Count;
        }
        private void ThreadBW_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (apiSelect == 0)
            {
				string url = string.Empty;

				if (!isSingle)
				{
					url = OMDB.multipleAddress + SearchTb.Text.Trim() + "&apikey=" + OMDB.api;
				}
				else
				{
					url = OMDB.singleAddress + SearchTb.Text.Trim() + "&apikey=" + OMDB.api;
				}
				using (WebClient wc = new WebClient())
				{
					string json = wc.DownloadString(url);
					List<string> imdbId = new List<string>();

					JavaScriptSerializer oJS = new JavaScriptSerializer();

					if (!isSingle)
					{
						Entity_M = oJS.Deserialize<ImdbEntity_M>(json);
						var movies = oJS.Serialize(Entity_M);

						if (Entity_M.Response == "True")
						{
							foreach (var movie in Entity_M.Search)
							{
								MovieUC MovieUserControl = new MovieUC(movie.imdbID, movie.Title, movie.Year, movie.Poster,
									movie.Type, TitleInWishList(movie.imdbID), TitleInSeenList(movie.imdbID), this);

								imdbId.Add(movie.imdbID);

								MoviesFLP.Invoke(new MethodInvoker(delegate
								{
									MoviesFLP.Controls.Add(MovieUserControl);
								}));
							}
						}
						else
						{
							MessageBox.Show("There was an error requesting movie data", "Error");
						}
					}
					else
					{
						Entity_S = oJS.Deserialize<ImdbEntity_S>(json);

						if (Entity_S.Response == "True")
						{
							MovieUC MovieUserControl = new MovieUC(Entity_M.imdbID, Entity_S.Title, Entity_S.Year, Entity_S.Poster,
								Entity_S.Type, TitleInWishList(Entity_S.imdbID), TitleInSeenList(Entity_S.imdbID), this);

							imdbId.Add(Entity_M.imdbID);

							MoviesFLP.Invoke(new MethodInvoker(delegate
							{
								MoviesFLP.Controls.Add(MovieUserControl);
							}));
						}
						else
						{
							MessageBox.Show("There was an error requesting movie data", "Error");
						}
					}
					SeenListUserControl = new SeenListUC(NumberOfMoviesSeenInSearchCategory(imdbId), this);
					MoviesFLP.Invoke(new MethodInvoker(delegate
					{
						MoviesFLP.Controls.Add(SeenListUserControl);
					}));

					WishListUserControl = new WishListUC(Properties.Settings.Default.WishList.Count, this);
					MoviesFLP.Invoke(new MethodInvoker(delegate
					{
						MoviesFLP.Controls.Add(WishListUserControl);
					}));
				}
			}
            else if (apiSelect== 1)
            {
                string url = string.Empty;

                if (!isSingle)
                {
                    url = TMDB.multipleAddress + "search/movie?api_key=" + TMDB.api + "&query=" + SearchTb.Text.Trim();
                }
                else
                {
                    url = TMDB.singleAddress + "search/movie?api_key=" + TMDB.api + "&query=" + SearchTb.Text.Trim();
                }
                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString(url);
                    List<string> imdb_id = new List<string>();

                    JavaScriptSerializer oJS = new JavaScriptSerializer();

                    if (!isSingle)
                    {
                        entity_Tmdb = oJS.Deserialize<TmdbEntity>(json);
                        var movies = oJS.Serialize(entity_Tmdb);

                        if (movies != null)
                        {

							foreach (var movie in entity_Tmdb.results)
                            {

                                MovieUC MovieUserControl = new MovieUC(movie.id, movie.title, movie.release_date, TMDB.posterUrl + movie.poster_path,
                                    "Movie", TitleInWishList(movie.imdb_id), TitleInSeenList(movie.imdb_id), this);

                                imdb_id.Add(movie.imdb_id);

                                MoviesFLP.Invoke(new MethodInvoker(delegate
                                {
                                    MoviesFLP.Controls.Add(MovieUserControl);
                                }));
                            }
                        }
                        else
                        {
                            MessageBox.Show("There was an error requesting movie data", "Error");
                        }
                    }
                    else
                    {
                        TMDB_entity_S = oJS.Deserialize<TmdbEntity_S>(json);

                        if (TMDB_entity_S.imdb_id != null)
                        {
                            string imdbID = TMDB_entity_S.imdb_id;
                            string Title = TMDB_entity_S.original_title;
                            string Year = TMDB_entity_S.release_date;
                            string Poster = TMDB_entity_S.poster_path;
                            string Type = TMDB_entity_S.genres;

                            MovieUC MovieUserControl = new MovieUC(imdbID, Title, Year, Poster,
                                    Type, TitleInWishList(imdbID), TitleInSeenList(imdbID), this);

                            imdb_id.Add(TMDB_entity_S.imdb_id);

                            MoviesFLP.Invoke(new MethodInvoker(delegate
                            {
                                MoviesFLP.Controls.Add(MovieUserControl);
                            }));
                        }
                        else
                        {
                            MessageBox.Show("There was an error requesting movie data", "Error");
                        }
                    }
                    SeenListUserControl = new SeenListUC(NumberOfMoviesSeenInSearchCategory(imdb_id), this);
                    MoviesFLP.Invoke(new MethodInvoker(delegate
                    {
                        MoviesFLP.Controls.Add(SeenListUserControl);
                    }));

                    WishListUserControl = new WishListUC(Properties.Settings.Default.WishList.Count, this);
                    MoviesFLP.Invoke(new MethodInvoker(delegate
                    {
                        MoviesFLP.Controls.Add(WishListUserControl);
                    }));
                }
            }
        }
        private void ThreadBW_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            this.LoadPb.Visible = false;
            this.MoviesFLP.Visible = true;
        }
        public void UpdateResultResult()
        {
            this.LoadPb.Visible = true;
            this.MoviesFLP.Visible = false;

			if (comboBox1.SelectedIndex == 0) { apiSelect = 0; }
			else if (comboBox1.SelectedIndex == 1) { apiSelect = 1; }

			if (MultipleCb.Checked) { isSingle = false; }
			else { isSingle = true; }

			this.MoviesFLP.Controls.Clear();

			this.ThreadBW.RunWorkerAsync();
        }
        public int NumberOfMoviesSeenInSearchCategory(List<string> imdbId)
        {
            int movieMatched = 0;

            for (int t = 0; t < imdbId.Count; t++)
            {
                for (int i = 0; i < Properties.Settings.Default.SeenList.Count; i++)
                {
                    if (Properties.Settings.Default.SeenList[i] == imdbId[t])
                    {
                        movieMatched++;
                    }
                }
            }
            return movieMatched;
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
			if (SearchTb.Text.Length > 50)
			{
				MessageBox.Show("Title length too long", "Error");
				return;
			}

            if (SearchTb.Text == "!Log")
            {
                System.Diagnostics.Process.Start(Application.StartupPath + "\\ChangeLog.txt");
                return;
            }

            if (SearchTb.Text == string.Empty || SearchTb.Text == "Search for movie title...")
                MessageBox.Show("Invalid search input", "Error");
            else
                UpdateResultResult();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            SeenListUserControl = new SeenListUC(0, this);
            MoviesFLP.Controls.Add(SeenListUserControl);
            WishListUserControl = new WishListUC(Properties.Settings.Default.WishList.Count, this);
            MoviesFLP.Controls.Add(WishListUserControl);
        }
    }
}
