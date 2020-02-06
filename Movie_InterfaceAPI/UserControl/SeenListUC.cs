using System.Windows.Forms;

namespace Movie_InterfaceAPI
{
    public partial class SeenListUC : UserControl
    {
        private Main Main;

        public SeenListUC(int moviesSeen, Main Main)
        {
            InitializeComponent();
            this.Main = Main;
            SeenListLb.Text = "You have seen " + moviesSeen + " movies in this search category";
        }
        private void SeenListBtn_Click(object sender, System.EventArgs e)
        {
            SeenList SeenListFrm = new SeenList(Main);
            SeenListFrm.ShowDialog();
        }

        private void SeenListLb_Click(object sender, System.EventArgs e)
        {

        }
    }
}
