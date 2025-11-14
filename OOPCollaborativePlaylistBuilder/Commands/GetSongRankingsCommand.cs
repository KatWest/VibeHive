using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaylistBuilderOOP.Models;

namespace PlaylistBuilderOOP.Commands
{
    internal class GetSongRankingsCommand
    {
        private Playlist _playlist;
        public GetSongRankingsCommand(string playlistId) 
        { 
            _playlist = Playlist.GetPlaylist(playlistId);
        }

        public List<Song> Execute()
        {
            List<Song> rankedSongList = _playlist.GetSongRankings();
            return rankedSongList;
        }
    }
}
