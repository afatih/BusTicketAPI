﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Ticket.BLL.IServices;
using Ticket.DTO;
using Ticket.Helpers;

namespace Ticket.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _userService;
        private readonly AppSettings _appSettings;
        private readonly ITokenService _tokenService;
        public UserController(IUserService userService, IOptions<AppSettings> appSettings,ITokenService tokenService)
        {
            _userService = userService;
            _appSettings = appSettings.Value;
            _tokenService = tokenService;
        }



        [HttpPost("authenticate")]
        public IActionResult Authenticate ([FromBody] UserDTO userDto)
        {
            var user = _userService.Authenticate(userDto.Email, userDto.Password);
            if (user==null)
                return BadRequest(new { message = "Email ya da şifre hatalı." });

            if (!user.IsActive)
                return BadRequest(new { message = "Hesabınızı aktif etmek için lütfen email hesabınıza gönderilen aktivasyon linkine tıklayınız." });

            var tokenString = _tokenService.GetToken(user.Id,_appSettings);

            // return basic user info (without password) and token to store client side
            return Ok(new
            {
                Id = user.Id,
                Name = user.Name,
                Surname = user.Surname,
                Email = user.Email,
                IsActive=user.IsActive,
                Token = tokenString
            });
        }

        [HttpPost("register")]
        public IActionResult Register([FromBody] UserDTO userDto)
        {

            try
            {
                _userService.Create(userDto);
                return Ok();
            }
            catch (Exception ex)
            {
                var x = ex.Message;
                return BadRequest(new { message = ex.Message });
            }

        }


        [HttpPost("activation")]
        public IActionResult ActivateUser([FromBody] ActivationKeyRequest activation)
        {
            if (activation == null)
                return BadRequest();
            
            if(string.IsNullOrEmpty(activation.ActivationKey))
                return BadRequest();

            try
            {
                var user = _userService.ActivateUser(activation.ActivationKey);
                if (user == null)
                    return NotFound(new { message= "Bu aktivasyon anahtarıyla kayıtlı bir kullanıcı bulunmamaktadır." } );


                var tokenString = _tokenService.GetToken(user.Id, _appSettings);


                // return basic user info (without password) and token to store client side
                return Ok(new
                {
                    Id = user.Id,
                    Name = user.Name,
                    Surname = user.Surname,
                    Email = user.Email,
                    IsActive = user.IsActive,
                    Token = tokenString
                });
            }
            catch (Exception ex )
            {
                return BadRequest(ex.Message);
            }       
        }
       

    }
}
