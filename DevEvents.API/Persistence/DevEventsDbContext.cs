using DevEvents.API.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevEvents.API.Persistence
{
   public class DevEventsDbContext : DbContext
   {
      public DevEventsDbContext(DbContextOptions<DevEventsDbContext> options) : base(options)
      {

      }

      public DbSet<Event> Events { get; set; }

      public DbSet<Category> Categories { get; set; }

      public DbSet<User> Users { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {

      }
   }
}
