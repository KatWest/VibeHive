namespace VibeHive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void albumManageBtn_Click(object sender, EventArgs e)
        {
            AlbumInventory albumInventory = new AlbumInventory();
            albumInventory.Show();
        }
    }
}
