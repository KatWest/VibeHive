using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaylistBuilderOOP.Models;

namespace PlaylistBuilderOOP.Commands
{
    internal class AddSongtoPlaylistCommand : Command
    {
        private readonly Song _Song;
        private readonly Playlist _Playlist;
        public List<Song> updatedPlaylistSongs;

        public AddSongtoPlaylistCommand(Song song, string playlistId)
        {
            _Song = song;

            _Playlist = Playlist.GetPlaylist(playlistId);
        }

        public void Execute()
        {
            _Playlist.AddSongToPlaylist(_Song.Id);
            updatedPlaylistSongs = _Playlist.GetSongRankings();
        }
    }
}
