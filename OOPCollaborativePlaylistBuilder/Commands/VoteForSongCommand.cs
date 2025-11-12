using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaylistBuilderOOP.Models;

namespace PlaylistBuilderOOP.Commands
{
    internal class VoteForSongCommand : Command
    {
        private Playlist _playlist;
        private Song _song;

        private bool _vote;

        public VoteForSongCommand(string songId, string playlistId, bool vote)
        {
            _vote = vote;

            //find playlist 
            _playlist = Playlist.GetPlaylist(playlistId);


            // Find the song in the specific playlist
            _song = _playlist.GetSong(songId);
        }

        public void Execute()
        {
            //vote up if true
            if (_vote == true)
            {
                _song.UpVotes();
            }

            //vote down if false
            if (_vote == false)
            {
                _song.DownVotes();
            }
        }

    }
}
