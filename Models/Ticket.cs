using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eventchain.Models
{
    public class Ticket
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TicketId { get; set; }
        public string Title { get; set; }

        //public int EventId { get; set; }
        //public Event Event { get; set; }

        public List<Event> SubEvents { get; set; }

    }
}
