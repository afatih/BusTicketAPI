using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Ticket.BLL.IServices;
using Ticket.DTO;

namespace Ticket.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class TourController : Controller
    {
        ITourService _tourService;

        public TourController(ITourService tourService)
        {
            _tourService = tourService;
        }

        [HttpGet]
        [Route("cities")]
        public IActionResult GetCities()
        {
            var cities = _tourService.GetCities();
            if (cities==null)
                NotFound();

            return Ok(cities);
        }

        [HttpPost]
        public IActionResult GetTours([FromBody] TourSelectDto dto)
        {
            if (string.IsNullOrEmpty(dto.From) || string.IsNullOrEmpty(dto.To))
                return BadRequest(new { message = "Lütfen tüm alanları doldurnuz" });

            if (dto.Date.Year == 1)
                return BadRequest(new { message="Lütfen tarih alanı için geçerli bir değer giriniz" });

            var cities = _tourService.GetTours(dto);

            if (cities == null)
                return NotFound(new { message = "Seçilen kriterlere uygun sefer bulunamamaktadır" });

            return Ok(cities);
        }

        [HttpGet]
        [Route("detail/{id}")]
        public IActionResult GetTourDetail(int id)
        {
            if (id==0)
                return BadRequest();

            var tour = _tourService.GetTourDetail(id);

            if (tour==null)
                return NotFound(new { message = "Seçilen sefer bulunamamaktadır" });

            return Ok(tour);
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddTourToUser([FromBody] UserTourDto dto) 
        {
      

            if (!ModelState.IsValid)
                return BadRequest();

            try
            {
                var result = _tourService.AddTourToUser(dto);
                if (result == 0)
                    return BadRequest(new { message="Bilet alma işlemi gerçekleştirilemedi" });


                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }


        [HttpGet]
        [Route("user/{id}")]
        public IActionResult GetUserTours(int id)
        {
            if (id == 0)
                return BadRequest();

            var tours = _tourService.GetUserTours(id);

            return Ok(tours);
        }


        [HttpDelete]
        public IActionResult DeleteUserTour([FromBody] DeleteTourRequestDto dto)
        {
            if (dto.userTourId == 0 || dto.tourId == 0)
                return BadRequest();
            try
            {
                var result = _tourService.DeleteUserTour(dto.userTourId, dto.tourId);
                if (result > 0)
                    return Ok();
                else
                    return BadRequest();
            }
            catch (Exception e)
            {

                return NotFound(new { message = e });
            }
        }






    }
}