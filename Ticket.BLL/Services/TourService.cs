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
            var cities = _cityRepository.Get(x => x.Id > 0).OrderBy(x => x.RowNumber);
            return _mapper.Map<IEnumerable<CityDto>>(cities);
        }

        public IEnumerable<TourDto> GetTours(TourSelectDto dto)
        {
            var tours = _tourRepository.Get(x => x.From == dto.From && x.To == dto.To && x.Date == dto.Date).OrderBy(x=>x.RowNumber);
            return _mapper.Map<IEnumerable<TourDto>>(tours);
        }

        public TourDto GetTourDetail(int id)
        {
            var tour = _tourRepository.Get(x => x.Id == id).SingleOrDefault();
            if (tour.UserCount >= 44)
            {
                throw new AppException("Seçili sefer için yolcu sayısı dolmuştur");
            }
            return _mapper.Map<TourDto>(tour);
        }

        public void AddTourToUser(UserTourDto dto)
        {

            using (var transaction = _uow.BeginTransaction())
            {
                try
                {
                    //User Tour tablosuna kullanıcı id ve tour id bilgileri işlendi
                    _userTourRepository.Add(_mapper.Map<UserTour>(dto));
                    _uow.Save();


                    //tour tablosunda ki userCount sayısı 1 adet arttırıldı.
                    var tour = _tourRepository.Get(x => x.Id == dto.TourId).SingleOrDefault();
                    tour.UserCount += 1;
                    _tourRepository.Update(tour);
                    _uow.Save();

                    transaction.Commit();

                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw new AppException(e.Message);
                }
            }
          

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
            return tours.OrderBy(x => x.Date).AsEnumerable();
            
        }


        
        public void DeleteUserTour(int id,int tourId)
        {


            using (var transaction = _uow.BeginTransaction())
            {
                try
                {
                    //UserTour  tablosundan seçili kayıt silindi
                    _userTourRepository.HardDelete(x => x.Id == id);
                    _uow.Save();

                    //Tour tablosunda o tura ait userCount sayısı 1 azaltıldı
                    var deletedTour = _tourRepository.Get(x => x.Id == tourId).SingleOrDefault();
                    if (deletedTour != null)
                    {
                        deletedTour.UserCount -= 1;
                    }
                    _uow.Save();

                    transaction.Commit();

                }
                catch(Exception ex)
                {
                    transaction.Rollback();
                    throw new AppException(ex.Message);
                }
            }

        }
    }
}
