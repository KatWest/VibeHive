using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaylistBuilderOOP.Models;

namespace PlaylistBuilderOOP.Commands
{
    internal class ListAllPlaylistsCommand
    {
        ListAllPlaylistsCommand() { }

        public void Execute() 
        {
            Playlist.GetAllPlaylists();
        }


    }
}
