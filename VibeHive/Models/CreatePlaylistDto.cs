using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Models
{
    public class CreatePlaylistDto
    {
        public string Name { get; set; }
        public bool isCollaborative { get; set; }
        public string CreatedBy { get; set; }
    }
}
