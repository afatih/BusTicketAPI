using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket.Entity.Entities
{
    public class UserKey
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string ActivationKey { get; set; }

    }
}
