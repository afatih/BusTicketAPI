using AutoMapper;
using Core.DAL;
using System;
using System.Collections.Generic;
using System.Text;
using Ticket.BLL.IServices;
using Ticket.DTO;
using Ticket.Entity.Entities;

namespace Ticket.BLL.Services
{
    public class TourService : ITourService
    {
        private IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IRepository<City> _cityRepository;
        private readonly IRepository<Tour> _tourRepository;
        public TourService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
            _cityRepository = _uow.GetRepository<City>();
            _tourRepository = _uow.GetRepository<Tour>();

        }
        public IEnumerable<CityDto> GetCities()
        {
            var cities = _cityRepository.Get(x => x.Id > 0);
            return _mapper.Map<IEnumerable<CityDto>>(cities);
        }

        public IEnumerable<TourDto> GetTours(TourSelectDto dto)
        {
            var tours = _tourRepository.Get(x => x.From == dto.From && x.To == dto.To /*&& x.Date == dto.Date*/);
            return _mapper.Map<IEnumerable<TourDto>>(tours);
        }
    }
}
