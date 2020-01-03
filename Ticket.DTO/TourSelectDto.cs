using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ticket.DTO
{
    public class TourSelectDto
    {

        public string From { get; set; }
        

        public string To { get; set; }
        

        public DateTime Date { get; set; }
    }
}
