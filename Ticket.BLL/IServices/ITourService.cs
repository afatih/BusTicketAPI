using System;
using System.Collections.Generic;
using System.Text;
using Ticket.DTO;
using Ticket.Entity.Entities;

namespace Ticket.BLL.IServices
{
    public interface ITourService
    {
        IEnumerable<CityDto> GetCities();

        IEnumerable<TourDto> GetTours(TourSelectDto dto);

        TourDto GetTourDetail(int id);

        int AddTourToUser(UserTourDto dto);

        IEnumerable<UserToursDetailDto> GetUserTours(int id);

        int DeleteUserTour(int id,int tourId);

 

    }
}
