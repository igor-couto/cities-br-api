using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Services;
using System.Text.Json;

namespace Presentation.Controllers
{
    [ApiController]
    public class CitiesController : Controller
    {
        private readonly ILogger<CitiesController> _logger;
        private readonly CityService _cityService;

        public CitiesController(ILogger<CitiesController> logger)
        {
            _logger = logger;
            _cityService = new CityService();
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
            return Json(_cityService.GetRandom(), new JsonSerializerOptions(){ IgnoreNullValues = true });
        }

    }
}