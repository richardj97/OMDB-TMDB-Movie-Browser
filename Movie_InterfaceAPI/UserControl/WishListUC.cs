using System.Windows.Forms;

namespace Movie_InterfaceAPI
{
    public partial class WishListUC : UserControl
    {
        private Main Main;

        public WishListUC(int movieCount, Main Main)
        {
            InitializeComponent();
            this.Main = Main;
            WishListLb.Text = "There are currently " + movieCount + " movies in your wish list";
        }
        private void WishListBtn_Click(object sender, System.EventArgs e)
        {
            WishList WishListFrm = new WishList(Main);
            WishListFrm.ShowDialog();
        }

        private void WishListLb_Click(object sender, System.EventArgs e)
        {

        }
    }
}
