using Events.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Data
{
    public class EventsContext:DbContext
    {
        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
        }

        public DbSet<Event> Courses { get; set; }
        public DbSet<RelatedEvent> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>().ToTable("Event");
            modelBuilder.Entity<RelatedEvent>().ToTable("RelatedEvent");
        }
    }
}
