using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static hafta2.DTOs.EventDtos;
using static hafta2.Services.EventService;

namespace hafta2.Controllers
{
    public class EventController
    {
        [Route("api/[controller]")]
        [Produces("application/json")]
        [Consumes("application/json")]
        [ApiController]
        public class EventController : ControllerBase
        {
            private readonly IEventService _eventService;

            public EventController(IEventService eventService)
            {
                _eventService = eventService;
            }

            [HttpPost("Add")]
            public IActionResult Add([FromBody]EventAddDto model)
            {
                var result = _eventService.Add(model);

                return Ok(result);
            }
        }
    }
}
