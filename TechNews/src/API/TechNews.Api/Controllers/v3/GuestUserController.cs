using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Features.Categories.Commands.CreateCategory;
using TechNews.Application.Features.GuestUsers.Commands.CreateGuestUser;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class GuestUserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public GuestUserController(IMediator mediator, ILogger<GuestUserController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpPost(Name = "AddGuestUser")]
        public async Task<ActionResult> Create([FromBody] CreateGuestUserCommand createGuestUser)
        {
            _logger.LogInformation("AddGuestUser Controller Initiated");
            var response = await _mediator.Send(createGuestUser);
            _logger.LogInformation("AddGuestUser Controller Completed");
            return Ok(response);
        }
    }
}
