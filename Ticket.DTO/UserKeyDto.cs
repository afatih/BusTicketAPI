using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket.DTO
{
    public class UserKeyDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string ActivationKey { get; set; }
    }
}
