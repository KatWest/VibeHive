using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP.Commands
{
    internal class AddSongtoPlaylistCommand : Command
    {
        private readonly Song Song;
        private readonly string PlaylistId;

        public AddSongtoPlaylistCommand(Song song, string playlistId)
        {
            Song = song;
            PlaylistId = playlistId;
        }

        public void Execute()
        {

        }
    }
}
