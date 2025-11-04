using MusicRentalAPI.Models;

namespace MusicRentalAPI.Services.Interfaces
{
    //what operations related to rental(rent album, return rented album, list all active rentals) 
    public interface IRentalService
    {
        Rental RentAlbum(int customerId, int musicAlbumId); //rent an album
        bool ReturnAlbum(int rentalId); //rental is returned
        IEnumerable<Rental> GetActiveRentals(); //list all active rentals 

    }
}
