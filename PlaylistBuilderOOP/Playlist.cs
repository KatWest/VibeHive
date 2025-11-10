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
        private readonly List<Song> _songs = new List<Song>();

        [JsonPropertyName("Name")]
        public string Name => DisplayName; //allows for inheritance from mediaItem but also keep json as request field name
        public bool IsCollaborative { get; private set; }
        public int CreatedBy { get; private set; } //userID
        public IReadOnlyList<Song> Songs => _songs.AsReadOnly();

        public Playlist(string id, string name, int createdBy, bool isCollaborative) : base(id, name)
        {
            CreatedBy = createdBy;
            IsCollaborative = isCollaborative;
        }

        public void AddSong(Song newSong)
        {
            if (!_songs.Any(song => song.Id == newSong.Id))
            {
                _songs.Add(newSong);
            }
        }

        public void RemoveSong(string songId)
        {
            _songs.RemoveAll(song => song.Id == songId);
        }
        

    }
}
