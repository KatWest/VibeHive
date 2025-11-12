using MusicRentalAPI.Models;

namespace MusicRentalAPI.Services.Interfaces
{
    //what operations related to music albums(add, list all, delete) 
    //ISP and DIP
    public interface IMusicService
    {
        Music AddAlbum(Music album); //adding a new album to the collection
        IEnumerable<Music> GetAllAlbums(); //get all/List all albums 
        bool DeleteAlbum(int musicId); //delete album by ID 
        Music? GetAlbumById(int musicId); //get album details




    }
}
