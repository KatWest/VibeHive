using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP.Models
{
    public class Song : MediaItem
    {
        private int _votes;

        [JsonPropertyName("Title")]
        public string Title => DisplayName; //allows for inheritance from mediaItem but also keep json as request field name
        public string Artist { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }
        public int Votes => _votes;

        public Song(string title, string artist, string genre, TimeSpan duration, int UpVotes, int DownVotes, string id, DateTime updatedAt) : base(title)
        {
            Artist = artist;
            Genre = genre;
            Duration = duration;
            _votes = 0; //votes start empty
        }

        public void UpVotes()
        {
            _votes++;
        }

        public void DownVotes()
        {
            _votes--;
        }

    }
}
