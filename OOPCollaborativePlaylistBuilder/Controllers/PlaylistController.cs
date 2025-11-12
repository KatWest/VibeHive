using Microsoft.AspNetCore.Mvc;
using PlaylistBuilderOOP.Commands;
using PlaylistBuilderOOP.Models;

namespace OOPCollaborativePlaylistBuilder.Controllers
{
    [ApiController]
    [Route("api/[controller")]
    public class PlaylistController : Controller
    {
        //POST /api/playlists: Create a new playlist.
        [HttpPost]
        public ActionResult<Playlist> CreatePlaylist([FromBody] Playlist playlist)
        {
            var createPlaylist = new CreatePlaylistCommand(playlist.Name, playlist.CreatedBy, playlist.IsCollaborative);
            createPlaylist.Execute();

            Playlist newPlaylist = createPlaylist.NewPlaylist;

            if (newPlaylist == null)
            {
                throw new Exception(message: "Your new playlist could not be created.");
            }
            return newPlaylist;
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
            return updatedSong;
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
            return allPlaylists;
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
            return songListRanked;
        }

        //PUT /api/playlists/{ id}/add: Add a song to a specific playlist.


        //PUT /api/playlists/{id}/invite: Invite other users to collaborate on a playlist.

    }
}
