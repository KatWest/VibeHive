using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP.Models
{
    public class Playlist : MediaItem
    {

        //public list of all playlists - json ignore so calls do not go in endless cycle
        [JsonIgnore]
        internal static Dictionary<string, Playlist> allPlaylists = new Dictionary<string, Playlist>();

        //instance of songs in playlist
        private readonly List<Song> _songs = new List<Song>();

        //userIds of approved collaborators
        private List<string> approvedCollaborators = new List<string>();

        [JsonPropertyName("Name")]
        public string Name => DisplayName; //allows for inheritance from mediaItem but also keep json as request field name
        public bool IsCollaborative { get; private set; }
        public string CreatedBy { get; private set; } //userID
        public IReadOnlyDictionary<string, Playlist> AllPlaylists => allPlaylists.AsReadOnly();
        public IReadOnlyList<Song> Songs => _songs.AsReadOnly();
        public List<string> ApprovedCollaborators => approvedCollaborators;

        public Playlist(string name, string createdBy, bool isCollaborative) : base(name)
        {
            CreatedBy = createdBy;
            IsCollaborative = isCollaborative;
        }

        //static methods
        internal static Playlist GetPlaylist(string playlistId)
        {
            allPlaylists.TryGetValue(playlistId, out var playlist);
            return playlist;
        }

        internal static List<Playlist> GetAllPlaylists()
        {
            return allPlaylists.Values.ToList();
        }

        internal static void AddPlaylistToDictionary(Playlist newPlaylist)
        {
            allPlaylists.TryAdd(newPlaylist.Id, newPlaylist);
        }

        //methods
        public void AddSongToPlaylist(string songId)
        {
            //check if song instance exists in playlist - if not add
            if (!_songs.Any(song => song.Id == songId))
            {
                //get song and add
                var newSong = GetSong(songId);
                _songs.Add(newSong);
            }
        }

        public void AddCollabUser(string userId, string collabId)
        {
            if (IsCollaborative == false)
            {
                return;
            }

            if (CreatedBy != userId)
            {
                return;
            }
            approvedCollaborators.Add(collabId);
        }

        public List<Song> GetSongRankings()
        {
            return _songs.OrderByDescending(Song => Song.Votes).ToList();
        }

        //helper
        public Song GetSong(string songId)
        {
            var song = _songs.FirstOrDefault(s => s.Id == songId);

            return song;
        }
    }
}
