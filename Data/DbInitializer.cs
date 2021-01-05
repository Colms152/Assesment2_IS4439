using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventchain.Data;
using Eventchain.Models;

namespace Eventchain.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Events.Any())
            {
                return;   // DB has been seeded
            }

            var @events = new Event[]
            {
            new Event{EventId = 20032021, EventName="Andrea Bocelli",EventDetails = "20 March in Cork Oprea House Andrea Bocelli Will Preform his Greatest Songs"},
            new Event{EventId = 13062021, EventName="Dua Lipa",EventDetails = "13 June in Croke Park Dua Lipa Will Preform Her New Album"},
            new Event{EventId = 10072021, EventName="Ed Sheeran",EventDetails = "10 July in Pairc Uí Caomhe Ed Sheeran Will Preform his New Album"},
            new Event{EventId = 01092021, EventName="Electric Picinic",EventDetails = "1 September Electric Picnic will take place for 3 day with many acts"},
            new Event{EventId = 20102021, EventName="Guinness Jazz Festival",EventDetails = "20 October a Number of Jazz preformance will take place across Cork City"}
            
            };
            foreach (Event s in @events)
            {
                context.Events.Add(s);
            }
            context.SaveChanges();

            var venues = new Venue[]
            {
            new Venue{Address="Cork Oprea House, Cork City", Capcity = "5000"},
            new Venue{Address="Croke Park, Dublin City", Capcity = "82300"},
            new Venue{Address="Pairc Uí Caomhe, Cork City", Capcity = "62000"},
            new Venue{Address="Stradbally, County Laois", Capcity = "100000"},
            new Venue{Address="Metopole Hotel, Cork City", Capcity = "5000"},
            new Venue{Address="Electric Bar, Cork City", Capcity = "300"},
            new Venue{Address="River Lee Hotel, Cork City", Capcity = "700"}
            };
            foreach (Venue c in venues)
            {
                context.Venues.Add(c);
            }
            context.SaveChanges();
            
            var infoes = new EventInfo[]
            {
            new EventInfo{EventId=20032021,Genre= "Opera",Recurring= false},
            new EventInfo{EventId=13062021,Genre= "pop",Recurring= false},
            new EventInfo{EventId=10072021,Genre= "Pop",Recurring= false},
            new EventInfo{EventId=01092021,Genre= "Festival",Recurring= false},
            new EventInfo{EventId=20102021,Genre= "Jazz",Recurring= false}
            };
            foreach (EventInfo e in infoes)
            {
                context.EventInfo.Add(e);
            }
            context.SaveChanges(); 
        }
    }
}
