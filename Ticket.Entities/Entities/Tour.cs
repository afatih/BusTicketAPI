using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket.Entity.Entities
{
    public class Tour
    {
        public int Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        public int UserCount { get; set; }
        public string Time { get; set; }
    }
}
