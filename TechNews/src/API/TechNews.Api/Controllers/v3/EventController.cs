using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using TechNews.Application.Features.EventSchedule.Queries.GetEventScheduleList;
using TechNews.Application.Features.EventSchedule.Queries.GetEventSheduleById;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<EventController> _logger;

        public EventController(IMediator mediator, ILogger<EventController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetAllEventSchedule")]
        public async Task<ActionResult> GetAllEventSchedule()
        {
            _logger.LogInformation("GetAllEventSchedule controller");
            var response = await _mediator.Send(new GetEventScheduleListQuery());
            _logger.LogInformation("GetAllEventSchedule controller completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetAllEventScheduleById")]
        public async Task<ActionResult> GetAllEventScheduleById(int id)
        {
            _logger.LogInformation("GetAllEventScheduleById controller");
            var response = await _mediator.Send(new GetEventSheduleByIdQuery() { SectionMasterId = id});
            _logger.LogInformation("GetAllEventScheduleById controller completed");
            return Ok(response);
        }
    }
}
