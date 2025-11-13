namespace OOPCollaborativePlaylistBuilder.Models
{
    public class SongApiRequest
    {
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public decimal DurationMinutes { get; set; }
        public decimal DurationSeconds { get; set; }
    }
}
