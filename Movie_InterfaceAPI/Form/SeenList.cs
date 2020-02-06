using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Movie_InterfaceAPI
{
    public partial class SeenList : Form
    {
        private Main Main;

        public SeenList(Main Main)
        {
            InitializeComponent();
            this.Main = Main;
        }
        private void WishList_Load(object sender, System.EventArgs e)
        {
            foreach (string title in Properties.Settings.Default.SeenList)
            {
                string url = OMDB.imdbAddress + title + "&apikey=" + OMDB.api;

                using (WebClient wc = new WebClient())
                {
                    string json = wc.DownloadString(url);

                    JavaScriptSerializer oJS = new JavaScriptSerializer();
                    ImdbEntity_S Entity_S = oJS.Deserialize<ImdbEntity_S>(json);

                    MovieUC MovieUserControl = new MovieUC(Entity_S.imdbID, Entity_S.Title, 
                        Entity_S.Year, Entity_S.Poster, Entity_S.Type, Main.TitleInWishList(Entity_S.imdbID), 
                        Main.TitleInSeenList(Entity_S.imdbID), Main);

                    MoviesFLP.Controls.Add(MovieUserControl);
                }
            }
        }
        private void WishListBtn_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Are you sure you wish to remove all the movies that you have seen?", "Remove seen list", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Properties.Settings.Default.SeenList.Clear();
                Properties.Settings.Default.Save();
                this.Close();
                Main.UpdateResultResult();
            } else { return; }
        }
    }
}
