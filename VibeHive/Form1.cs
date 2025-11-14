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

        private void musicRentalBtn_Click(object sender, EventArgs e)
        {
            MusicRentalForm musicRental = new MusicRentalForm();
            musicRental.Show();
        }

        private void playlistBuilderBtn_Click(object sender, EventArgs e)
        {
            CollaborativePlaylistBuilderForm playlistBuilder = new CollaborativePlaylistBuilderForm();
            playlistBuilder.Show();
        }
    }
}
