using AutoMapper;
using Core.DAL;
using Core.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ticket.BLL.IServices;
using Ticket.DTO;
using Ticket.Entity.Entities;

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
            throw new NotImplementedException();
        }

        public ServiceResult Add(UserDTO dto)
        {
            var userEntitiy = _mapper.Map<User>(dto);
            _uow.GetRepository<User>().Add(userEntitiy);
            return _uow.Save();
        }
    }
}
