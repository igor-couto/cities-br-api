using CitiesBR.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Text.Json;

namespace CitiesBR.API.Controllers
{
    [ApiController]
    public class CitiesController : Controller
    {
        private readonly ILogger<CitiesController> _logger;
        private readonly ICityService _cityService;

        public CitiesController(ILogger<CitiesController> logger, ICityService cityService)
        {
            _logger = logger;
            _cityService = cityService;
        }

        /// <summary>
        /// Get all the cities.
        /// </summary>
        /// <returns>Returns all cities</returns>
        [HttpGet]
        [Route("cities")]
        public IActionResult GetAll()
        {
            return Json(_cityService.GetAll(), new JsonSerializerOptions(){IgnoreNullValues = true});
        }

        /// <summary>
        /// .
        /// </summary>
        /// <param name="name">.</param>
        /// <returns>.</returns>
        [HttpGet()]
        [Route("city/{name}")]
        //[Route("city/{id}")]
        public IActionResult GetCityByName(string name)
        {
            return Json(_cityService.GetCityByName(name), new JsonSerializerOptions(){IgnoreNullValues = true});
        }

        /// <summary>
        /// A.
        /// </summary>
        /// <param name="id">.</param>
        /// <returns>.</returns>
        [HttpGet()]
        [Route("city/{id}")]
        public IActionResult GetCityById(int id)
        {
            return Json(_cityService.GetCityById(id), new JsonSerializerOptions(){IgnoreNullValues = true});
        }

        
        /// <summary>
        /// Get a city randomicaly
        /// </summary>
        /// <returns>.</returns>
        [HttpGet()]
        [Route("city/ramdon")]
        public IActionResult GetRandom()
        {
            return Json(_cityService.GetRandon(), new JsonSerializerOptions(){ IgnoreNullValues = true });
        }

    }
}