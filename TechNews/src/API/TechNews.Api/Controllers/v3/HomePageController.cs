using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Features.HomePage.Queries.GetBreakingNews;
using TechNews.Application.Features.HomePage.Queries.TreandingVideo;
using TechNews.Application.Features.NewsLetters.Command.AddNewsLetter;
using TechNews.Application.Features.NewsLetters.Query.NewsLetterEmailExist;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class HomePageController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public HomePageController(IMediator mediator, ILogger<GuestUserController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpGet]
        [Route("BreakingNews")]
        public async Task<ActionResult> GetBreakingNews()
        {
            _logger.LogInformation("Inside Home page controller (GetBreakingNews");
            var response = await _mediator.Send(new GetBreakingNewsQuery());
            _logger.LogInformation("GetBreakingNews ActionMethod Completes");
            return Ok(response);
        }
        [HttpPost]
        [Route("AddNewsLetter")]
        public async Task<ActionResult> AddNewsLetter(AddNewsLetterCommand addNewsLetterCommand)
        {
            _logger.LogInformation("AddNewsLetter Controller Initiated");
            var response = await _mediator.Send(addNewsLetterCommand);
            _logger.LogInformation("AddNewsLetter Controller Completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("TreandingVideos")]
        public async Task<ActionResult> GetTreandingNews()
        {
            _logger.LogInformation("Inside Home page controller (GetTreandingNews");
            var response = await _mediator.Send(new GetTreandingVideoQuery());
            _logger.LogInformation("GetTreandingNews ActionMethod Completes");
            return Ok(response);
        }
        [HttpGet]
        [Route("AddNewsLetter")]
        public async Task<ActionResult> NewsLetterEmailExist(string email)
        {
            _logger.LogInformation("NewsLetterEmailExist Controller Initiated");
            var response = await _mediator.Send(new NewsLetterEmailExistQuery() { Email = email });
            _logger.LogInformation("NewsLetterEmailExist Controller Completed");
            return Ok(response);
        }


    }

}
