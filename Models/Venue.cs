using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventchain.Models
{
    public class Venue
    {
        public int VenueId { get; set; }
        public string Address { get; set; }
        public string Capcity { get; set; }

        
        
        public List<Event> Events { get; set; }
    }
}
