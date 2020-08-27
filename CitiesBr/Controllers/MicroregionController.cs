using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CitiesBr.Controllers
{
    [ApiController]
    public class MicroregionController : Controller
    {
        private readonly ILogger<MicroregionController> _logger;

        public MicroregionController(ILogger<MicroregionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get all the microregions
        /// </summary>
        [HttpGet()]
        [Route("microregions")]
        public IActionResult Get()
        {
            return NotFound();
        }

        /// <summary>
        /// Get a microregion by name
        /// <param name="name"> Microregion name</param>
        /// </summary>
        [HttpGet()]
        [Route("microregion/{name}")]
        public IActionResult Get(string name)
        {
            return NotFound();
        }

        /// <summary>
        /// Get a microregion by id
        /// <param name="id"> Microregion id</param>
        /// </summary>
        [HttpGet()]
        [Route("microregion/{id}")]
        public IActionResult Get(int id)
        {
            return NotFound();
        }
    }
}