using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP
{
    public class PlaylistService
    {
        private readonly Dictionary<string, Playlist> Playlists;
        private readonly List<Song> Songs;

        public PlaylistService(Dictionary<string, Playlist> playlists, List<Song> songs)
        {
            Playlists = playlists;
            Songs = songs;
        }

        public void AddSongToPlaylist(string playlistId, Song song)
        {
            var playlist = Playlists.FirstOrDefault(p => p.Id == playlistId);
            if(playlist == null)
            {
                return;
                //need to add error
            }
            playlist.AddSong(song);    
        }

        public void VoteForSong(Song song, string playlistId, bool vote)
        {
            //find playlist - do i need this?
            var playlist = Playlists.ContainsKey(playlistId);
            if (playlist == null)
            {
                return;
                //error
            }

            //find song in playlist
            var selectedSong = Songs.FirstOrDefault(s => s.Id == song.Id);

            if(selectedSong == null) 
            { 
                return;
                //error
            }

            //vote up if true
            if(vote == true)
            {
                selectedSong.
            }

            //vote down if false
        }
    }
}
