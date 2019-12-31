using System;
using System.Collections.Generic;
using System.Text;

namespace Ticket.DTO
{
    public class UserLoginDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Code
        {
            get
            {
                Guid obj = Guid.NewGuid();
                return obj.ToString();
            }
        }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
    }
}
