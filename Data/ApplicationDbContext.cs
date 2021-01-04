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
               
        public DbSet<Event> Events { get; set; }
        public DbSet<Venue> Venues { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        
    }
}
