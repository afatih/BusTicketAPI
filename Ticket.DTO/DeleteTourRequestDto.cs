using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket.DTO
{
    public class DeleteTourRequestDto
    {
        public int userTourId { get; set; }
        public int tourId { get; set; }
    }
}
