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
        private readonly IRepository<User> _repository;
        public UserService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
            _repository = _uow.GetRepository<User>();

        }

        public  IEnumerable<UserDTO> Get()
        {
            return  _mapper.Map<IEnumerable<UserDTO>>(_repository.Get(x => x.Id > 0));
        }

        public UserDTO Get(int id)
        {
            var user = _repository.Get(x=>x.Id==id).SingleOrDefault();
            var userDto = _mapper.Map<UserDTO>(user);
            return userDto;
        }

        public UserDTO Create(UserDTO dto)
        {
            // validation
            if (string.IsNullOrWhiteSpace(dto.Password) || string.IsNullOrWhiteSpace(dto.Email))
                throw new AppException("Password is required");



            var userEntitiy = _mapper.Map<User>(dto);
            _uow.GetRepository<User>().Add(userEntitiy);
            _uow.Save();
            return dto;
        }

        public UserDTO Get(UserLoginDTO dto)
        {
            var user = _repository.Get(x => x.Email == dto.Email && x.Password == dto.Password).SingleOrDefault();
            var userDto = _mapper.Map<UserDTO>(user);
            return userDto;
        }

        public UserDTO Authenticate(string email, string password)
        {
            if (string.IsNullOrEmpty(email)||string.IsNullOrEmpty(password))
                return null;
            var user = _repository.Get(x => x.Email == email && x.Password == password).SingleOrDefault();

            if (user == null)
                return null;

            return _mapper.Map<UserDTO>(user);

        }
    }
}
