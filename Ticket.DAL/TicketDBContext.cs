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
        }
    }
}
