namespace MusicRentalAPI.Models
{
    //represents a rental transaction in the music rental system, tracks which user rented which album and when
    public class Rental
    {
        public int RentalId { get; set; }
        public int CustomerId { get; set; }
        public int MusicAlbumId { get; set; }
        public DateTime RentalDate { get; set; }
        public DateTime? RentalReturn { get; set; }
    }
}
