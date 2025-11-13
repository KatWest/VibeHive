using Microsoft.AspNetCore.Mvc;
using OOPCollaborativePlaylistBuilder.Models;
using PlaylistBuilderOOP.Commands;
using PlaylistBuilderOOP.Models;
using AppUser = PlaylistBuilderOOP.User;

namespace OOPCollaborativePlaylistBuilder.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlaylistController : Controller
    {
        //ToDo: fix created by check - currently getting 404 error

        //POST /api/playlists: Create a new playlist.
        [HttpPost]
        public ActionResult<Playlist> CreatePlaylist([FromBody] Playlist playlist)
        {
            if (string.IsNullOrWhiteSpace(playlist.Name))
            {
                return BadRequest("Playlist Name is required");
            }

            if(string.IsNullOrWhiteSpace(playlist.CreatedBy))
            {
                return BadRequest("CreatedBy is Required");
            }

            //asp.net(core) has built in claims so need this to circumvent to be able to compare id and createdBy
            var userExists = PlaylistBuilderOOP.User.UsersList.Any(u => u.Id == playlist.CreatedBy);
            if(userExists == null)
            {
                return NotFound("User doesn't exist.");
            }

            try
            {
                var createPlaylist = new CreatePlaylistCommand(playlist.Name, playlist.CreatedBy, playlist.IsCollaborative);
                createPlaylist.Execute();

                Playlist newPlaylist = createPlaylist.NewPlaylist;

                return Ok(newPlaylist);
            }
            catch (Exception ex)
            {
                return Problem(title: "Unexpected error", detail: ex.Message, statusCode: 500);
            }
        }

        //POST /api/playlists/{id}/vote: Vote on a song within a collaborative playlist.
        [HttpPost("{playlistId}/vote")]
        public ActionResult<Song> VoteOnSong(string songId, string playlistId, bool vote)
        {
            var songVote = new VoteForSongCommand(songId, playlistId, vote);
            songVote.Execute();

            Song updatedSong = songVote.UpdatedSong;

            if (updatedSong == null)
            {
                throw new Exception(message: $"The playlist with Id: {playlistId} could not update the song with Id: {songId}");
            }
            return Ok(updatedSong);
        }

        //GET /api/playlists: List all playlists created by users.
        [HttpGet]
        public ActionResult<List<Playlist>> GetAllPlaylists()
        {
            var playlists = new ListAllPlaylistsCommand();

            List<Playlist> allPlaylists = playlists.Execute();

            if (allPlaylists == null)
            {
                throw new Exception(message: $"There are no playlists.");
            }
            return Ok(allPlaylists);
        }

        //GET /api/playlists/{ id}/rankings: Get ranked list of songs based on votes.
        [HttpGet("{playlistId}/rankings")]
        public ActionResult<List<Song>> GetRankedSongsListByPlaylist(string playlistId)
        {
            var rankedSongList = new GetSongRankingsCommand(playlistId);
            List<Song> songListRanked = rankedSongList.Execute();

            if (songListRanked == null)
            {
                throw new Exception(message: $"Was not able to find songs rankings for playlist Id: {playlistId}");
            }
            return Ok(songListRanked);
        }

        //PUT /api/playlists/{id}/add: Add a song to a specific playlist.
        [HttpPost("{playlistId}/add")]
        public ActionResult<List<Song>> AddSongToPlaylist([FromRoute]string playlistId, [FromBody]Song song)
        {
            var addSongtoPlaylist = new AddSongtoPlaylistCommand(song, playlistId);
            addSongtoPlaylist.Execute();

            List<Song> updatedPlaylistSongs = addSongtoPlaylist.updatedPlaylistSongs;

            if(updatedPlaylistSongs == null)
            {
                throw new Exception(message: $"Adding the song with Id: {song.Id} to playlist Id: {playlistId} failed.");
            }
            return Ok(updatedPlaylistSongs);
        }

        //PUT /api/playlists/{id}/invite: Invite other users to collaborate on a playlist.
        [HttpPost("{playlistId}/invite")]
        public ActionResult<List<string>> AddUserAsPlaylistCollaborator([FromRoute]string playlistId, [FromBody]CollabUserApiRequest CollabUser)
        {


            var addNewCollabUserToPlayList = new AddCollaboratorCommand(playlistId, CollabUser.userId, CollabUser.collabUserId);
            addNewCollabUserToPlayList.Execute();

            List<string> newPlaylistCollabUserIds = addNewCollabUserToPlayList.collabUserList;

            if(newPlaylistCollabUserIds == null)
            {
                throw new Exception(message: $"Unable to add user with Id: {CollabUser.collabUserId} as collaborator on playlist id:{playlistId}");
            }
            return Ok(newPlaylistCollabUserIds);
        }
    }
}
