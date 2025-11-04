using Microsoft.AspNetCore.Mvc;
using MusicRentalAPI.Models;
using MusicRentalAPI.Services.Interfaces;

namespace MusicRentalAPI.Controllers
{
    //Handles API requests for music albums, SRP 
    [ApiController]
    [Route("api/[controller]")]
    public class MusicController : Controller
    {
        private readonly IMusicService _musicService;
        public MusicController(IMusicService musicService)
        {
            _musicService = musicService;
        }

        //add an album 
        [HttpPost]
        public IActionResult AddAlbum( Music album)
        {
            //Validate Title
            if (string.IsNullOrWhiteSpace(album.Title))
            {
                return BadRequest("Title is required.");
            }

            // Validate Artist
            if (string.IsNullOrWhiteSpace(album.Artist))
            {
                return BadRequest("Artist is required.");
            }

            // Validate Genre
            if (string.IsNullOrWhiteSpace(album.Genre))
            {
                return BadRequest("Genre is required.");
            }

            // Validate Year (positive and not in the future)
            if (album.Year <= 0 || album.Year > DateTime.Now.Year)
            {
                return BadRequest("Year must be a positive number and cannot be in the future.");
            }

            // Call the service to add the album
            var addedAlbum = _musicService.AddAlbum(album);

            // Return 200 success response
            return Ok($"{addedAlbum} has been added successfully :)");
        }

        //get all albums
        [HttpGet]
        public IActionResult GetAllAlbums() => Ok(_musicService.GetAllAlbums());

        //delete by ID

        [HttpDelete("{id}")]
        public IActionResult DeleteAlbum(int id)
        {
            //Call service to delete the album
            bool isDeleted = _musicService.DeleteAlbum(id);

            //Check if album was successfully deleted
            if (isDeleted)
            {
                // If deleted, return Ok
                return Ok("Music Album deleted successfully");
            }
            else
            {
                //If not found, return HTTP 404 with message
                return NotFound("Music Album is not found.");
            }
        }
    }

}

