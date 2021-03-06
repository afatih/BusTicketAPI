﻿using AutoMapper;
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
            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<Tour, TourDto>().ReverseMap();
            CreateMap<Tour, UserToursDetailDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<UserTour, UserTourDto>().ReverseMap();
        }
    }
}
