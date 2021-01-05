using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventchain.Models
{
    public class EventInfo
    {
        public int EventInfoId { get; set; }
        public string Genre { get; set; }
        public bool Recurring { get; set; }
        public int EventId { get; set; }
        public Event Parent { get; set; }

    }
}
