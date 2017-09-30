using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prosjektoppgave.Models
{
    public class DB : DbContext
    {
        public DB() : base("name=DB")
        {
            Database.CreateIfNotExists();
            Database.SetInitializer(new DBInit());
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Schedule> Schedules { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        public virtual DbSet<Passenger> Passengers { get; set; }
    } 
}