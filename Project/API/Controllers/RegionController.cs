using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CitiesBR.API.Controllers
{
    [ApiController]
    public class RegionController : Controller
    {
        private readonly ILogger<RegionController> _logger;

        public RegionController(ILogger<RegionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get all regions
        /// </summary>
        [HttpGet()]
        [Route("regions")]
        public IActionResult Get()
        {
            return NotFound();
        }

        /// <summary>
        /// Get a region by name
        /// <param name="name"> Region name</param>
        /// </summary>
        [HttpGet()]
        [Route("region/{name}")]
        public IActionResult Get(string name)
        {
            return NotFound();
        }

        /// <summary>
        /// Get a region by id
        /// <param name="id"> Region id</param>
        /// </summary>
        [HttpGet()]
        [Route("region/{id}")]
        public IActionResult Get(int id)
        {
            return NotFound();
        }
    }
}