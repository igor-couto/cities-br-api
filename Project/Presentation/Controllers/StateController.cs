using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Application.Services;

namespace Presentation.Controllers
{
    [ApiController]
    public class StateController : Controller
    {
        private readonly ILogger<StateController> _logger;
        private readonly StateService _stateService;

        public StateController(ILogger<StateController> logger)
        {
            _logger = logger;
            _stateService = new StateService();
        }

         /// <summary>
        /// Get all states
        /// </summary>
        /// <returns>All states of Brazil</returns>
        [HttpGet()]
        [Route("states")]
        public IActionResult Get()
        {
            return NotFound();
        }

        /// <summary>
        /// Get a state by name
        /// </summary>
        /// <param name="name">State name</param>
        /// <returns>Return the state</returns>
        [HttpGet()]
        [Route("state/{name}")]
        public IActionResult Get(string name)
        {
            return Json(_stateService.GetRandom());
        }

        /// <summary>
        /// Get a state by id
        /// </summary>
        /// <param name="id">State id</param>
        /// <returns>Return the state</returns>
        [HttpGet()]
        [Route("state/{id}")]
        public IActionResult Get(int id)
        {
            return NotFound();
        }
    }
}