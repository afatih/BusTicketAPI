using System;
using System.Collections.Generic;
using System.Text;
using Ticket.DTO;

namespace Ticket.BLL.IServices
{
    public interface ITourService
    {
        IEnumerable<CityDto> GetCities();

        IEnumerable<TourDto> GetTours(TourSelectDto dto);

    }
}
