using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VibeHive.Models
{
    public class RentalDto
    {
        public int RentalId { get; set; }
        public int CustomerId { get; set; } //Customer.CustomerId
        public int MusicId { get; set; } //Music.MusicId
        public DateTime RentalDate { get; set; }
        public DateTime? RentalReturn { get; set; }
    }
}
