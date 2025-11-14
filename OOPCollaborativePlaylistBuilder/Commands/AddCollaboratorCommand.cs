using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlaylistBuilderOOP.Models;

namespace PlaylistBuilderOOP.Commands
{
    internal class AddCollaboratorCommand
    {
        private string _userId;
        private string _collaboratorId;
        private Playlist _playlist;
        public List<string> collabUserList; //list of userIds approved to collab - null until execute run

        public AddCollaboratorCommand(string playlistId, string userId, string collabUserId ) 
        {
            _userId = userId;
            _collaboratorId = collabUserId;

            _playlist = Playlist.GetPlaylist(playlistId);
        }

        public void Execute()
        {
            _playlist.AddCollabUser(_userId, _collaboratorId);

            collabUserList = _playlist.ApprovedCollaborators;
        }
    }
}
