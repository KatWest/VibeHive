using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP.Commands
{
    internal class VoteForSongCommand : Command
    {
        private Playlist _playlist;
        private Song _song;

        private string _songId;
        private string _playlistId;
        private bool _vote;

        public VoteForSongCommand(string songId, string playlistId, bool vote)
        {
            _songId = songId;
            _playlistId = playlistId;
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
