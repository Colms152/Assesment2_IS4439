using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventchain.Models
{
    public class Event
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDetails { get; set; }
        
        //One to many relatioship - Every Event has one User
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

    }
}
