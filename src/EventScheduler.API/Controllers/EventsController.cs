using EventScheduler.Application.Contracts.Events;
using Microsoft.AspNetCore.Mvc;

namespace EventScheduler.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventsService _eventsService;

        public EventsController(IEventsService eventsService)
        {
            _eventsService = eventsService ?? throw new ArgumentNullException(nameof(eventsService));
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var events = _eventsService.GetEvents();
            return Ok(events);
        }
    }
}
