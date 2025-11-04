using Microsoft.AspNetCore.Mvc;
using MusicRentalAPI.Services.Interfaces;

namespace MusicRentalAPI.Controllers
{
    //Handles API requests fo renting and returning albums
    //works with RentalService and MusicService to coordinate transactions and album avail updates
    [ApiController]
    [Route("api/[controller]")]
    public class RentalController : Controller
    {
        private readonly IRentalService _rentalService;
        public RentalController(IRentalService rentalService)
        {
            _rentalService = rentalService;
        }

        //rent a music album
        [HttpPost]
        public IActionResult RentAlbum(int customerId, int musicAlbumId)
        {
            try
            {
                //Call the rental service to rent the album
                var rentedAlbum = _rentalService.RentAlbum(customerId, musicAlbumId);

                //Return success message if rental was successful
                string message = $"{rentedAlbum} has been rented successfully.";
                return Ok(message);
            }
            catch (Exception ex)
            {
                //Return bad request if an error occurs such as album not being available
                return BadRequest(ex.Message);
            }
        }

        //return a music album 

        [HttpPost("{rentalId}/return")]
        public IActionResult ReturnAlbum(int rentalId)
        {
            //Call rental service to return the album
            bool isReturned = _rentalService.ReturnAlbum(rentalId);

            //Check if the return was successful
            if (isReturned)
            {
                return Ok("Album returned successfully.");
            }
            else
            {
                return NotFound("Rental was not found or has already been returned.");
            }
        }

        //retrieve all active rentals from rental service and return 200 ok with list of active rentals
        [HttpGet]
        public IActionResult GetActiveRentals()
        {
            //Call rental service to retrieve all active rentals
            var activeRentals = _rentalService.GetActiveRentals();

            //Return the list of active rentals with HTTP 200 OK
            return Ok(activeRentals);
        }



    }




}
