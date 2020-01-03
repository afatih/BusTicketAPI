using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ticket.Entity.Entities;

namespace Ticket.DAL
{
    public class TicketDBContext:DbContext
    {
        public TicketDBContext(DbContextOptions<TicketDBContext> options):base(options)
        {

        }
        public DbSet<User> Users{ get; set; }
        public DbSet<City> Cities{ get; set; }
        public DbSet<Tour> Tours{ get; set; }
        public DbSet<UserTour> UserTours{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { Id=1, Name = "test1", Email = "test1@gmail.com", Password = "test", IsActive = true, Surname = "testSoyad" },
                new User() { Id = 2, Name = "test2", Email = "test2@gmail.com", Password = "test", IsActive = true, Surname = "testSoyad" },
                new User() { Id = 3, Name = "test3", Email = "test3@gmail.com", Password = "test", IsActive = true, Surname = "testSoyad" }
                );

            modelBuilder.Entity<City>().HasData(
                new City() { Id = 1, Name = "İstanbul", RowNumber = 1 },
                new City() { Id = 2, Name = "Ankara", RowNumber = 2 },
                new City() { Id = 3, Name = "İzmir", RowNumber = 3 }
                );

            modelBuilder.Entity<Tour>().HasData(
                new Tour() { Id = 1, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 30, Time = "16:00" },
                new Tour() { Id = 2, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 44, Time = "17:00" },
                new Tour() { Id = 3, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 20, Time = "18:00" },
                new Tour() { Id = 4, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 50, UserCount = 20, Time = "16:00" },
                new Tour() { Id = 5, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 50, UserCount = 20, Time = "18:00" },
                new Tour() { Id = 6, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 30, Time = "16:00" },
                new Tour() { Id = 7, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 44, Time = "17:00" },
                new Tour() { Id = 8, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 1, Time = "18:00" },
                new Tour() { Id = 9, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 30, Time = "16:00" },
                new Tour() { Id = 10, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 44, Time = "16:00" },
                new Tour() { Id = 11, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 1, Time = "16:00" },
                new Tour() { Id = 12, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 5, Time = "16:00" }
                );
        }
    }
}
