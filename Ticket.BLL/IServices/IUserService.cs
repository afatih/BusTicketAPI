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
        IEnumerable<UserDTO> Get();
        UserDTO Get(int id);
        ServiceResult Add(UserDTO dto);

    }
}
