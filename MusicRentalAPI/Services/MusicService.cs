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
        private static readonly List<Music> _albums = new();
        private static int nextAlbumId = 1; //track next album id

        //add album
        public Music AddAlbum(Music album)
        {
            album.MusicId = nextAlbumId++;
            album.IsAvailable = true;
            _albums.Add(album);
            return album;
        }

        //delete album
        public bool DeleteAlbum(int musicId)
        {
            var album = _albums.FirstOrDefault(a => a.MusicId == musicId);

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
        public Music? GetAlbumById(int musicId) => _albums.FirstOrDefault(a => a.MusicId == musicId); //album details
    }
}
