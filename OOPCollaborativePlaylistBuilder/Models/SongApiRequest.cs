namespace OOPCollaborativePlaylistBuilder.Models
{
    public class SongApiRequest
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }
        //Duration = new
        //{
        //    minutes = numericUpDown_songMinutes.Value,
        //    seconds = numericUpDown_songSeconds.Value
    }
}
