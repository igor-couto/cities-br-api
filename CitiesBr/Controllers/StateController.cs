using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CitiesBr.Model;
using CitiesBr.Services;

namespace CitiesBr.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StateController : Controller
    {
        private readonly ILogger<CitiesController> _logger;
        private readonly StateService _stateService;

        public StateController(ILogger<CitiesController> logger)
        {
            _logger = logger;
            _stateService = new StateService();
        }

        [HttpGet]
        public IActionResult Get(string state)
        {
            var states = new List<State>();

            return Json(_stateService.GetRandom());

            // if(string.IsNullOrEmpty(state))
            //     states = _stateService.GetAllStates();
            // else if(state.Length <= 2)
            //     states = _stateService.GetByAbbreviation(state);
            // else 
            //     states = _stateService.GetByName(state);

            //return Json(states);
        }
    }
}