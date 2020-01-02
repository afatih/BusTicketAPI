using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        [HttpGet]
        public IActionResult GetTours([FromBody] TourSelectDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var cities = _tourService.GetTours(dto);

            if (cities == null)
                NotFound(new { message = "Seçilen kriterlere uygun sefer bulunamamaktadır" });

            return Ok(cities);
        }



    }
}