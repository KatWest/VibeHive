using Microsoft.AspNetCore.Http.HttpResults;
using MusicRentalAPI.Models;
using MusicRentalAPI.Services.Interfaces;

namespace MusicRentalAPI.Services
{
    //implement operations for managing music albums 
    //handles logic like validation + crud operations 
    //using in memory storage (list) 
    public class MusicService : IMusicService
    {
        private readonly List<Music> _albums = new();
       
        //add album
        public Music AddAlbum(Music album)
        {
            album.MusicId = _albums.Count + 1;
            album.isAvailable = true;
            _albums.Add(album);
            return album;
        }

        //delete album
        public bool DeleteAlbum(int id)
        {
            var album = _albums.FirstOrDefault(a => a.MusicId == id);

            //check if album exists 
            if (album != null)
            {
                
                _albums.Remove(album);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //list all albums
        public IEnumerable<Music> GetAllAlbums()
        {
            return _albums;
        }
        public Music? GetAlbumById(int id) => _albums.FirstOrDefault(a => a.MusicId == id); //album details
    }
}
