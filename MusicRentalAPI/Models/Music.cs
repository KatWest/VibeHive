using System.Diagnostics.Eventing.Reader;

namespace MusicRentalAPI.Models
{
    //represents a music album in the rental system, this is the core data model for available albums
    public class Music
    {
        public int MusicId { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public bool IsAvailable { get; set; }
    }
}
