using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventchain.Models
{
    public class EventInfo
    {
        public int EventInfoId { get; set; }
        public string EventLocation { get; set; }
        public string EventCapcity { get; set; }

        //One to Many relatioship - One Event has one User but Users can have many events
        public string EventId { get; set; }
        public Event Event { get; set; }
    }
}
