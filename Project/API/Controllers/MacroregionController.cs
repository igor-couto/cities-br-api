using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CitiesBR.API.Controllers
{
    [ApiController]
    public class MacroregionController : Controller
    {
        private readonly ILogger<MacroregionController> _logger;

        public MacroregionController(ILogger<MacroregionController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Get all the macroregions
        /// </summary>
        [HttpGet()]
        [Route("macroregions")]
        public IActionResult Get()
        {
            return NotFound();
        }

        /// <summary>
        /// Get a district by macroregion
        /// <param name="name"> Macroregion name</param>
        /// </summary>
        [HttpGet()]
        [Route("macroregion/{name}")]
        public IActionResult Get(string name)
        {
            return NotFound();
        }

        /// <summary>
        /// Get a macroregion by id
        /// <param name="id"> Macroregion id</param>
        /// </summary>
        [HttpGet()]
        [Route("macroregion/{id}")]
        public IActionResult Get(int id)
        {
            return NotFound();
        }
    }
}