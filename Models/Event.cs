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
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDetails { get; set; }
        
        //One to One relatioship - Every Event has one User
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        //For many to many relationships in objects -> List of each other in both - Events have many tickets, A ticket can have many events
        //***************
            
            
        //One to many relatioship - Every Event has one User
        public List<Ticket> Tickets { get; set; }

    }
}
