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
         
         modelBuilder.Entity<Event>().ToTable("tb_event");
         modelBuilder.Entity<Event>().HasKey(e => e.id);

         modelBuilder.Entity<Event>()
            .HasOne(e => e.category)
            .WithMany()
            .HasForeignKey(e => e.idCategory);

         modelBuilder.Entity<Event>()
            .HasOne(e => e.user)
            .WithMany()
            .HasForeignKey(e => e.idUser);


         modelBuilder.Entity<User>().ToTable("tb_user");
         modelBuilder.Entity<User>().HasKey(e => e.id);

         modelBuilder.Entity<Category>().ToTable("tb_category");
         modelBuilder.Entity<Category>().HasKey(e => e.id);

      }
   }
}
