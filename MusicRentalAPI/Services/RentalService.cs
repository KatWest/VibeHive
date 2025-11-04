using MusicRentalAPI.Models;
using MusicRentalAPI.Services.Interfaces;

namespace MusicRentalAPI.Services
{
    //implement operations related to rent and return album 
    //works with MusicService to update album availability  and track active rentals 
    public class RentalService : IRentalService
    {
        private readonly IMusicService _musicService;
        private readonly List<Rental> _rentals = new();

        // Dependency Injection: RentalService depends on IMusicService interface, not the MusicService specifically
        public RentalService(IMusicService musicService)
        {
            _musicService = musicService;
        }

        //rent album 
        public Rental RentAlbum(int customerId, int musicAlbumId)
        {
            var album = _musicService.GetAlbumById(musicAlbumId);

            //check if album is not available 
            if (album == null || !album.isAvailable)
            {
                throw new InvalidOperationException("Album is not available for rent :(");
            }
            album.isAvailable = false;
            var rental = new Rental 
            {
                RentalId = _rentals.Count + 1,
                CustomerId = customerId,
                MusicAlbumId = musicAlbumId,
                RentalDate = DateTime.Now
            };

            _rentals.Add(rental);
            return rental;


        }
        //return album 
        public bool ReturnAlbum(int rentalId)
        {
            var rental = _rentals.FirstOrDefault(r => r.RentalId == rentalId);

            //check if there is a rental with no return date 
            if (rental == null || rental.RentalReturn != null)
                return false;

            var album = _musicService.GetAlbumById(rental.MusicAlbumId);
            if (album != null) album.isAvailable = true;

            rental.RentalReturn = DateTime.Now;
            return true;
        }

       
        public IEnumerable<Rental> GetActiveRentals() 
        {
            return _rentals.Where(r => r.RentalReturn == null);
            
        }
    }
}
