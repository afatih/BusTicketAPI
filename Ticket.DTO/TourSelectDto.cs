using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ticket.DTO
{
    public class TourSelectDto
    {
        [Required]
        public string From { get; set; }
        
        [Required]
        public string To { get; set; }
        
        [Required]
        public DateTime Date { get; set; }
    }
}
