using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Models
{
    public class SongDto
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Artist { get; set; }
        public string Genre { get; set; }
        public TimeSpan Duration { get; set; }
        public int Votes { get; set; }
    }
}
