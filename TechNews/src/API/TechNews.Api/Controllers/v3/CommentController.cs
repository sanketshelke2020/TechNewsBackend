using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Features.Comments.Command.AddComment;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public CommentController(IMediator mediator, ILogger<CommentController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpPost]
        [Route("AddComment")]
        public async Task<ActionResult> AddComment(AddCommentCommand addCommentCommand)
        {
            _logger.LogInformation("Inside comment controller (AddComment");
            var response = await _mediator.Send(addCommentCommand);
            _logger.LogInformation("AddComment ActionMethod Completes");
            return Ok(response);
        }
    }
}
