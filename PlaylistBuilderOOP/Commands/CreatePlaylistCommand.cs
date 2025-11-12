using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP.Commands
{
    internal class CreatePlaylistCommand: Command
    {
        Playlist _newPlaylist;

        public CreatePlaylistCommand(string id, string name, string createdBy, bool isCollaborative) 
        {
            _newPlaylist = new Playlist(id, name, createdBy, isCollaborative);
        }

        public void Execute() 
        { 
            Playlist.AddPlaylistToDictionary(_newPlaylist);
        }
    }
}
