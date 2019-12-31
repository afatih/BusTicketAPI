using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Ticket.Entities;

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
    }
}
