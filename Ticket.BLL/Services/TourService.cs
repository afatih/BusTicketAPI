using AutoMapper;
using Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly IRepository<UserTour> _userTourRepository;
        public TourService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
            _cityRepository = _uow.GetRepository<City>();
            _tourRepository = _uow.GetRepository<Tour>();
            _userTourRepository = _uow.GetRepository<UserTour>();

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

        public TourDto GetTourDetail(int id)
        {
            var tour = _tourRepository.Get(x => x.Id == id).SingleOrDefault();
            return _mapper.Map<TourDto>(tour);
        }

        public int AddTourToUser(UserTourDto dto)
        {
            _userTourRepository.Add(_mapper.Map<UserTour>(dto));
            return _uow.Save();

        }

        public IEnumerable<TourDto> GetUserTours(int id)
        {
            List<TourDto> tours = new List<TourDto>();
            var userTours = _userTourRepository.Get(x => x.Id>=0);

            if (userTours == null)
                return null;

            if (userTours.Count == 0)
                return tours;    

            foreach (UserTour item in userTours)
            {
                var tour = _tourRepository.Get(x => x.Id == item.TourId).SingleOrDefault();
                var tourDto = _mapper.Map<TourDto>(tour);
                tours.Add(tourDto);
            }
            return tours.AsEnumerable();
            
        }
    }
}
