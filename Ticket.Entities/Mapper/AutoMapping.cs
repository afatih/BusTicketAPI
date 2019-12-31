using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Ticket.DTO;
using Ticket.Entity.Entities;

namespace Ticket.Entity.Mapper
{
    public class AutoMapping:Profile
    {
        public AutoMapping()
        {
            CreateMap<User, UserDTO>();
            CreateMap<UserDTO, User>();
        }
    }
}
