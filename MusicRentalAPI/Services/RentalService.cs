using MusicRentalAPI.Models;
using MusicRentalAPI.Services.Interfaces;

namespace MusicRentalAPI.Services
{
    //implement operations related to rent and return album 
    //works with MusicService to update album availability  and track active rentals 
    public class RentalService : IRentalService
    {
        private readonly IMusicService _musicService;
        private readonly ICustomerService _customerService;
        private readonly List<Rental> _rentals = new();
        private static int nextRentalId = 1;

        // cpnstructor using ependency Injection: RentalService depends on IMusicService interface, not the MusicService specifically, customer service for custoemr data
        public RentalService(IMusicService musicService, ICustomerService customerService)
        {
            _musicService = musicService;
            _customerService = customerService;
            
        }

        //rent album to specific customer
        public Rental RentAlbum(int customerId, int musicId)
        {
            try
            {
                //Validate that customer exists
                var customer = _customerService.GetById(customerId);
                if (customer == null)
                    throw new Exception("Customer was not found.");

                //Validate that the album exists
                var album = _musicService.GetAlbumById(musicId);
                if (album == null)
                    throw new Exception("Album was not found.");

                //Check if the album is available to rent
                if (!album.IsAvailable)
                    throw new Exception("Album is not available to rent.");

                //Mark the album as rented
                album.IsAvailable = false;

                //Create a new rental record
                var rental = new Rental
                {
                    RentalId = nextRentalId++,
                    CustomerId = customerId,
                    MusicId = musicId,
                    RentalReturn = DateTime.Now
                };

                //Add rental to list
                _rentals.Add(rental);

                //Return the rental record
                return rental;
            }
            catch (Exception ex)
            {
                //error
                throw new Exception($"Unable to rent album: {ex.Message}");
            }


        }
        //return album 
        public bool ReturnAlbum(int rentalId)
        {
            var rental = _rentals.FirstOrDefault(r => r.RentalId == rentalId);

            //check if there is a rental with no return date 
            if (rental == null || rental.RentalReturn != null)
                return false;

            var album = _musicService.GetAlbumById(rental.MusicId);
            if (album != null) album.IsAvailable = true;

            rental.RentalReturn = DateTime.Now;
            return true;
        }

       
        public IEnumerable<Rental> GetActiveRentals() 
        {
            return _rentals.Where(r => r.RentalReturn == null);
            
        }
    }
}
