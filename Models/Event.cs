using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Eventchain.Models
{
    public class Event
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDetails { get; set; }

        //One to Many relatioship - One Event has one User but Users can have many events
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        //For many to many relationships in objects -> List of each other in both - Events can have many venues, An venue can host many events
        public List<Venue> Venues { get; set; }

        
        
        public EventInfo Information { get; set; }
    }
}
