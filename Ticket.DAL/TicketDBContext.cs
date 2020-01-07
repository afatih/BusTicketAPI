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
        public DbSet<UserKey> UserKeys{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            //modelBuilder.Entity<City>().HasData(
            //    new City() { Id = 1, Name = "İstanbul", RowNumber = 1 },
            //    new City() { Id = 2, Name = "Ankara", RowNumber = 2 },
            //    new City() { Id = 3, Name = "İzmir", RowNumber = 3 }
            //    );

            //modelBuilder.Entity<Tour>().HasData(
            //    new Tour() { Id = 1, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 43, Time = "16:00" },
            //    new Tour() { Id = 2, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 44, Time = "17:00" },
            //    new Tour() { Id = 3, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 42, Time = "18:00" },
            //    new Tour() { Id = 4, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 1, Time = "19:00" },
            //    new Tour() { Id = 5, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date, Price = 50, UserCount = 2, Time = "20:00" },
            //    new Tour() { Id = 6, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 7, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 50, UserCount = 20, Time = "17:00" },
            //    new Tour() { Id = 8, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(2), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 9, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(3), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 10, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(4), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 11, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(5), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 12, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(6), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 13, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(7), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 14, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(8), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 15, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(9), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 16, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(10), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 17, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(11), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 18, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(12), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 19, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(13), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 20, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(14), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 21, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(15), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 22, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(16), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 23, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(17), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 24, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(18), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 25, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(19), Price = 50, UserCount = 20, Time = "16:00" },
            //    new Tour() { Id = 26, From = "İstanbul", To = "Ankara", Date = DateTime.Now.Date.AddDays(20), Price = 50, UserCount = 20, Time = "16:00" },

            //    new Tour() { Id = 27,  From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 43, Time = "10:00" },
            //    new Tour() { Id = 28,  From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 44, Time = "11:00" },
            //    new Tour() { Id = 29,  From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 42, Time = "12:00" },
            //    new Tour() { Id = 30, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 1, Time = "19:00" },
            //    new Tour() { Id = 31, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date, Price = 30, UserCount = 2, Time = "20:00" },
            //    new Tour() { Id = 32, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(1), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 33, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(1), Price = 30, UserCount = 20, Time = "11:00" },
            //    new Tour() { Id = 34, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(2), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 35, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(3), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 36, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(4), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 37, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(5), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 38, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(6), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 39, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(7), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 40, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(8), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 41, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(9), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 42, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(10), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 43, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(11), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 44, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(12), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 45, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(13), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 46, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(14), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 47, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(15), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 48, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(10), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 49, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(11), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 50,  From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(12), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 51, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(19), Price = 30, UserCount = 20, Time = "10:00" },
            //    new Tour() { Id = 52, From = "İstanbul", To = "İzmir", Date = DateTime.Now.Date.AddDays(20), Price = 30, UserCount = 20, Time = "10:00" },



            //    new Tour() { Id = 53, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 43, Time = "14:00" },
            //    new Tour() { Id = 54, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 44, Time = "15:00" },
            //    new Tour() { Id = 55, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 42, Time = "16:00" },
            //    new Tour() { Id = 56, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 1, Time = "17:00" },
            //    new Tour() { Id = 57, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date, Price = 20, UserCount = 2, Time = "18:00" },
            //    new Tour() { Id = 58, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 59, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(1), Price = 20, UserCount = 20, Time = "15:00" },
            //    new Tour() { Id = 60, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(2), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 61, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(3), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 62, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(4), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 63, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(5), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 64, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(6), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 65, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(7), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 66, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(8), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 67, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(9), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 68, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(14), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 69, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(11), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 70, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(12), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 71, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(13), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 72, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(14), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 73, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(15), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 74, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(14), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 75, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(11), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 76, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(12), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 77, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(19), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 78, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(20), Price = 20, UserCount = 20, Time = "14:00" },
            //    new Tour() { Id = 79, From = "İzmir", To = "Ankara", Date = DateTime.Now.Date.AddDays(21), Price = 20, UserCount = 20, Time = "14:00" }
                                   
        }
    }
}
