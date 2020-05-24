using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CitiesBr.Schema;
using CitiesBr.Model;
using CitiesBr.Services;

namespace CitiesBr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CitiesController : Controller
    {
        private readonly ILogger<CitiesController> _logger;
        private readonly CityService _cityService;


        public CitiesController(ILogger<CitiesController> logger)
        {
            _logger = logger;
            _cityService = new CityService();
        }

        [HttpGet]
        public IActionResult Get(CityRequest request)
        {
            return Json(_cityService.GetCity(request));
        }
    }
}