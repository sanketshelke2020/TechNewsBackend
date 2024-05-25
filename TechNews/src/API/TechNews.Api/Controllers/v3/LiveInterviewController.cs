using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.LiveInterviews.Queries.GetListOfLiveInteriviews;
using TechNews.Application.Features.LiveInterviews.Queries.GetLiveInterviewById;
using TechNews.Application.Features.Podcast.Queries.GetAllpodcast;
using TechNews.Application.Features.Podcast.Queries.GetPodcastById;
using TechNews.Domain.Entities;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class LiveInterviewController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public LiveInterviewController(IMediator mediator, ILogger<LiveInterview> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetAllLiveInterview")]
        public async Task<ActionResult> GetAllLiveInterview()
        {
            _logger.LogInformation("Inside LiveInterview controller ");
            var response = await _mediator.Send(new GetListOfLiveInterviewQuery());
            _logger.LogInformation("LiveInterview ActionMethod Completes");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetLiveInterviewById")]
        public async Task<ActionResult> GetLiveInterviewById(int id)
        {
            _logger.LogInformation("Inside LiveInterview controller ");
            var response = await _mediator.Send(new GetLiveInterviewByIdQuery() { SectionMasterId = id });
            _logger.LogInformation("LiveInterviewId ActionMethod Completes");
            return Ok(response);
        }
    }
}
