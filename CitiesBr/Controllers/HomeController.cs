using System.Text.Json;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CitiesBr.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        private readonly ILogger<CitiesController> _logger;


        public HomeController(ILogger<CitiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var url = Request.GetDisplayUrl();
            return Json(new { cities_url = url + "cities", states_url = url + "states" }, new JsonSerializerOptions(){IgnoreNullValues = true});
        }
    }
}