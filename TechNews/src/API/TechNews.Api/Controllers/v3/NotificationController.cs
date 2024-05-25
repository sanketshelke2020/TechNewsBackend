using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByDate;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByKeyword;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public NotificationController(IMediator mediator, ILogger<NotificationController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetSectionAddedToday")]
        public async Task<ActionResult> GetSectionByDate(string i)
        {
            _logger.LogInformation("Inside GetSectionByDate controller ");
            var response = await _mediator.Send(new GetSectionMasterByDateQuery());
            _logger.LogInformation("GetSectionByDate ActionMethod Completes");
            if (i == "count")
            {
                return Ok(response.Data.Count);
            }
            return Ok(response);
        }
    }
}

