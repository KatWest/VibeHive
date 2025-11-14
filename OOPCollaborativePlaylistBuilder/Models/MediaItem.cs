using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaylistBuilderOOP.Models
{
    public abstract class MediaItem
    {
        public string Id { get; set; } 

        protected string _displayName;
        public DateTime CreatedAt { get; set; }

        public MediaItem(string displayName)
        {
            Id = Guid.NewGuid().ToString();
            _displayName = displayName;
            CreatedAt = DateTime.Now; //when instance is created initially it also saves it as the createdAt time
        }

        public string DisplayName => _displayName;
    }
}
