using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ticket.BLL.IServices;
using Ticket.DTO;

namespace Ticket.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public  IEnumerable<UserDTO> Get()
        {
            return  _userService.Get();
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get(UserLoginDTO dto)
        {
            if (dto==null)
            {
                return BadRequest();
            }
            return Ok(_userService.Get(dto));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] UserDTO user)
        {
            _userService.Add(user);
        }
    }
}
