using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaylistBuilderOOP.Models;

namespace PlaylistBuilderOOP.Commands
{
    internal class CreatePlaylistCommand: Command
    {
        private Playlist _newPlaylist;
        public Playlist NewPlaylist;

        public CreatePlaylistCommand(string name, string createdBy, bool isCollaborative) 
        {
            _newPlaylist = new Playlist(name, createdBy, isCollaborative);
        }

        public void Execute() 
        { 
            Playlist.AddPlaylistToDictionary(_newPlaylist);
            NewPlaylist = _newPlaylist;
        }
    }
}