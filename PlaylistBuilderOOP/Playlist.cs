using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP
{
    public class Playlist : MediaItem
    {
        //public list of all playlists
        internal static Dictionary<string, Playlist> AllPlaylists = new Dictionary<string, Playlist>();

        //instance of songs in playlist
        private readonly List<Song> _songs = new List<Song>();

        //userIds of approved collaborators
        private List<string> approvedCollaborators = new List<string>(); 

        [JsonPropertyName("Name")]
        public string Name => DisplayName; //allows for inheritance from mediaItem but also keep json as request field name
        public bool IsCollaborative { get; private set; }
        public string CreatedBy { get; private set; } //userID
        public IReadOnlyList<Song> Songs => _songs.AsReadOnly();
        public IReadOnlyList<string> ApprovedCollaborators => approvedCollaborators.AsReadOnly();

        public Playlist(string id, string name, string createdBy, bool isCollaborative) : base(id, name)
        {
            CreatedBy = createdBy;
            IsCollaborative = isCollaborative;
        }

        internal static Playlist GetPlaylist(string playlistId)
        {
            AllPlaylists.TryGetValue(playlistId, out var playlist);
            return playlist;
        }

        public void AddSongToPlaylist(string songId)
        {
            //check if song instance exists
            if (!_songs.Any(song => song.Id == songId))
            {
                //get song and add
                var newSong = GetSong(songId);
                _songs.Add(newSong);
            }
        }

        public void RemoveSongToPlaylist(string songId)
        {
            _songs.RemoveAll(song => song.Id == songId);
        }
        
        
        public void AddCollabUser(string userId, string collabId)
        {
            if(IsCollaborative == false)
            {
                return;
            }

            if(CreatedBy != userId)
            {
                return;
            }
            approvedCollaborators.Add(collabId);
        }

        //helper
        public Song GetSong(string songId)
        {
            var song = _songs.FirstOrDefault(s => s.Id == songId);

            return song;
        }




    }
}
