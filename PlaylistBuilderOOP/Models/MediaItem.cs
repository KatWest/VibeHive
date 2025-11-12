using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP.Models
{
    public abstract class MediaItem
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();

        protected string _displayName;
        public DateTime CreatedAt { get; set; }

        public MediaItem(string id, string displayName)
        {
            Id = id;
            CreatedAt = DateTime.Now; //when instance is created initially it also saves it as the createdAt time
            _displayName = displayName;
        }

        public string DisplayName => _displayName;
    }
}
