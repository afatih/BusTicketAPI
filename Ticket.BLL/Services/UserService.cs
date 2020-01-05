using AutoMapper;
using Core.DAL;
using Core.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ticket.BLL.IServices;
using Ticket.DTO;
using Ticket.Entity.Entities;
using Ticket.Helpers;

namespace Ticket.BLL.Services
{
    public class UserService : IUserService
    {
        private IUnitOfWork _uow;
        private readonly IMapper _mapper;
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<UserKey> _userKeyRepository;
        public UserService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
            _userRepository = _uow.GetRepository<User>();
            _userKeyRepository = _uow.GetRepository<UserKey>();

        }

        public  IEnumerable<UserDTO> Get()
        {
            return  _mapper.Map<IEnumerable<UserDTO>>(_userRepository.Get(x => x.Id > 0));
        }

        public UserDTO Get(int id)
        {
            var user = _userRepository.Get(x=>x.Id==id).SingleOrDefault();
            var userDto = _mapper.Map<UserDTO>(user);
            return userDto;
        }

        public UserDTO Create(UserDTO dto)
        {
            // validation
            if (string.IsNullOrWhiteSpace(dto.Password) || string.IsNullOrWhiteSpace(dto.Email))
                throw new AppException("Password is required");

            var usersBySelectedEmail = _userRepository.Get(x => x.Email.ToLower() == dto.Email.ToLower()).ToList();
            if (usersBySelectedEmail!=null)
            {
                if (usersBySelectedEmail.Count>0)
                {
                    if (!usersBySelectedEmail.FirstOrDefault().IsActive)
                    {
                        throw new AppException("Bu mail adresi için bir aktivasyon linki gönderilmiştir lütfen mail adresinizi kontrol ediniz");
                    }
                    throw new AppException("Bu e-mail adresi ile kayıtlı bir hesap vardır lütfen başka bir e-mail adresi giriniz.");
                }
            }

            using(var transaction = _uow.BeginTransaction())
            {
                try
                {
                    var userEntitiy = _mapper.Map<User>(dto);
                    _userRepository.Add(userEntitiy);
                    _uow.Save();


                

                    string guidId = Guid.NewGuid().ToString();
                    var userKey = new UserKey() { Email = dto.Email, ActivationKey = guidId };
                    _userKeyRepository.Add(userKey);
                    _uow.Save();

                    transaction.Commit();
                }
                catch (Exception e)
                {
                    transaction.Rollback();
                    throw new AppException("Kullanıcı kayıt olurken beklenmedik bir hata ile karşılaşıldı");
                  
                }
               

            }

          




            return dto;
        }

        public UserDTO Get(UserLoginDTO dto)
        {
            var user = _userRepository.Get(x => x.Email == dto.Email && x.Password == dto.Password).SingleOrDefault();
            var userDto = _mapper.Map<UserDTO>(user);
            return userDto;
        }

        public UserDTO Authenticate(string email, string password)
        {
            if (string.IsNullOrEmpty(email)||string.IsNullOrEmpty(password))
                return null;
            var user = _userRepository.Get(x => x.Email == email && x.Password == password).SingleOrDefault();

            if (user == null)
                return null;

            return _mapper.Map<UserDTO>(user);

        }

        public UserDTO ActivateUser(string key)
        {
            var userKey = _userKeyRepository.Get(x => x.ActivationKey == key).SingleOrDefault();
            if (userKey == null)
                return null;

            var user = _userRepository.Get(x => x.Email.ToLower() == userKey.Email.ToLower()).SingleOrDefault();
            if (user == null)
                return null;

            user.IsActive =true;

            _userRepository.Update(user);
            _uow.Save();

            return _mapper.Map<UserDTO>(user);
        }   
    }
}
