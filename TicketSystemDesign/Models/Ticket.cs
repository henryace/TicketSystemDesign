using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketSystemDesign.Models
{
    //public class TicketContext : DbContext
    //{
    //    public DbSet<Ticket> Tickets { get; set; }

    //    public string DbPath { get; private set; }

    //    public TicketContext()
    //    {
    //        var folder = Environment.SpecialFolder.LocalApplicationData;
    //        var path = Environment.GetFolderPath(folder);
    //        DbPath = $"{path}{System.IO.Path.DirectorySeparatorChar}blogging.db";
    //    }

    //    // The following configures EF to create a Sqlite database file in the
    //    // special "local" folder for your platform.
    //    protected override void OnConfiguring(DbContextOptionsBuilder options)
    //        => options.UseSqlite($"Data Source={DbPath}");
    //}
    public class Ticket
    {

        public Ticket()
        {

        }

        public string TicketId { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        public string Severity { get; set; }

        public string Priority { get; set; }


    }
}
