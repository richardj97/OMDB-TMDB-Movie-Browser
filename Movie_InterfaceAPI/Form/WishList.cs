using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Movie_InterfaceAPI
{
    public partial class WishList : Form
    {
        private Main Main;

        public WishList(Main Main)
        {
            InitializeComponent();
			this.Main = Main;
        }
        private void WishList_Load(object sender, System.EventArgs e)
        {
            foreach (string imdb in Properties.Settings.Default.WishList)
            {
                string url = OMDB.imdbAddress + imdb + "&apikey=" + OMDB.api;

                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString(url);

                    JavaScriptSerializer oJS = new JavaScriptSerializer();
                    ImdbEntity_S Entity_S = oJS.Deserialize<ImdbEntity_S>(json);

                    MovieUC MovieUserControl = new MovieUC(Entity_S.imdbID, Entity_S.Title, Entity_S.Year, Entity_S.Poster, Entity_S.Type, Main.TitleInWishList(Entity_S.imdbID), Main.TitleInSeenList(Entity_S.imdbID), Main);
                    MoviesFLP.Controls.Add(MovieUserControl);
                }
            }
        }
        private void WishListBtn_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove all the movies in your wish list?", "Remove wish list", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Properties.Settings.Default.WishList.Clear();
                Properties.Settings.Default.Save();
                this.Close();
                Main.UpdateResultResult();
            }
        }
    }
}
