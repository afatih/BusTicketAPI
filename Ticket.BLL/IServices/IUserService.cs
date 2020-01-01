using Core.Results;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Ticket.DTO;

namespace Ticket.BLL.IServices
{
    public interface IUserService
    {
        UserDTO Authenticate(string email, string password);
        IEnumerable<UserDTO> Get();
        UserDTO Get(int id);
        UserDTO Get(UserLoginDTO dto);
        UserDTO Create(UserDTO dto);



    }
}
