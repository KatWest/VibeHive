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
        public List<Playlist> allPlaylists; //null until executed

        public ListAllPlaylistsCommand() { }

        public List<Playlist> Execute() 
        {
            allPlaylists = Playlist.GetAllPlaylists();

            return allPlaylists;
        }
    }
}
