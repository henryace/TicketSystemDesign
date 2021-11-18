using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TicketSystemDesign.Models;

namespace TicketSystemDesign.Data
{
    public class TicketSystemDesignContext : DbContext
    {
        public TicketSystemDesignContext (DbContextOptions<TicketSystemDesignContext> options)
            : base(options)
        {
        }

        public DbSet<TicketSystemDesign.Models.Ticket> Tickets { get; set; }
        public DbSet<TicketSystemDesign.Models.User> Users { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().ToTable("Ticket");
            modelBuilder.Entity<User>().ToTable("User");


        }
    }
}
