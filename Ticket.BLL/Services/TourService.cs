using AutoMapper;
using Core.DAL;
using Core.Exceptions;
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
            if (tour.UserCount >= 44)
            {
                throw new AppException("Seçili seferde ki kişi sayısı dolmuştur");
            }
            return _mapper.Map<TourDto>(tour);
        }

        public int AddTourToUser(UserTourDto dto)
        {
           
           

            _userTourRepository.Add(_mapper.Map<UserTour>(dto));

            var result1 = _uow.Save();
            var result2 = 0;

            if (result1>0)
            {
                var tour = _tourRepository.Get(x => x.Id == dto.TourId).SingleOrDefault();
                tour.UserCount +=1 ;
                _tourRepository.Update(tour);
                result2 = _uow.Save();
            }

            if (result1 > 0 && result2 > 0)
                return 1;
            else
                return 0;

        }

        public IEnumerable<UserToursDetailDto> GetUserTours(int id)
        {
            List<UserToursDetailDto> tours = new List<UserToursDetailDto>();
            var userTours = _userTourRepository.Get(x => x.UserId==id);

            if (userTours == null)
                return null;

            if (userTours.Count == 0)
                return tours;    

            foreach (UserTour item in userTours)
            {
                var tour = _tourRepository.Get(x => x.Id == item.TourId).SingleOrDefault();
                var userTour = _mapper.Map<UserToursDetailDto>(tour);
                userTour.UserTourId = item.Id;
                tours.Add(userTour);
            }
            return tours.AsEnumerable();
            
        }


        
        public int DeleteUserTour(int id,int tourId)
        {

            _userTourRepository.HardDelete(x=>x.Id==id);
            
            var result1 = _uow.Save();
            var result2 = 0;

            if (result1 != 0)
            {
                var deletedTour = _tourRepository.Get(x => x.Id == tourId).SingleOrDefault();
                if (deletedTour!=null)
                {
                    deletedTour.UserCount -= 1;
                }

                result2 = _uow.Save();
            }

            if (result1 > 0 && result2 > 0)
                return 1;
            else
                return 0;

        }
    }
}
