using PlaylistBuilderOOP.Models;

namespace OOPCollaborativePlaylistBuilder.Models
{
    public class SongVoteApiRequest
    {
            public string songId { get; set; }
            public bool vote {  get; set; }
    }
}
