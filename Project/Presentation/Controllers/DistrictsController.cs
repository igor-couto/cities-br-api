using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Services;

namespace Presentation.Controllers
{
    [ApiController]
    public class DistricsController : Controller
    {
        private readonly ILogger<CitiesController> _logger;

        public DistricsController(ILogger<CitiesController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get all the districts
        /// </summary>
        [HttpGet()]
        [Route("districs")]
        public IActionResult Get()
        {
            return NotFound();
        }

        /// <summary>
        /// Get a district by name
        /// <param name="name"> Distric name</param>
        /// </summary>
        [HttpGet()]
        [Route("district/{name}")]
        public IActionResult Get(string name)
        {
            return NotFound();
        }

        /// <summary>
        /// Get a district by id
        /// <param name="id"> Distric id</param>
        /// </summary>
        [HttpGet()]
        [Route("district/{id}")]
        public IActionResult Get(int id)
        {
            return NotFound();
        }
    }
}