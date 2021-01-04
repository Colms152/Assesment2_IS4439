using System;
using System.Collections.Generic;
using System.Text;
using Eventchain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Eventchain.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .HasMany<Venue>(s => s.EventVenues)
                .WithMany(c => c.Events)
                .Map(cs =>
                {
                    cs.MapLeftKey("StudentRefId");
                    cs.MapRightKey("CourseRefId");
                    cs.ToTable("StudentCourse");
                });
            
        //Can't run both blocks
            modelBuilder.Entity<EventVenue>()
                .HasKey(bc => new { bc.EventId, bc.VenueId });
            modelBuilder.Entity<EventVenue>()
                .HasOne(bc => bc.Event)
                .WithMany(b => b.EventVenues)
                .HasForeignKey(bc => bc.EventId);
            modelBuilder.Entity<EventVenue>()
                .HasOne(bc => bc.Venue)
                .WithMany(c => c.Events)
                .HasForeignKey(bc => bc.VenueId); 
        }
        */
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        
    }
}
