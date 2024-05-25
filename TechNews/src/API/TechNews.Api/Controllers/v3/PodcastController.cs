using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Podcast.Queries.GetAllpodcast;
using TechNews.Application.Features.Podcast.Queries.GetChapterById;
using TechNews.Application.Features.Podcast.Queries.GetPodcastById;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class PodcastController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ILogger _logger;
        private readonly IPodcastRepository _podcastRepository;

        public PodcastController(IMediator mediator, ILogger<PodcastController> logger, IPodcastRepository podcastRepository)
        {
            _mediator = mediator;
            _logger = logger;
            _podcastRepository = podcastRepository;
        }
         
        [HttpGet]
        [Route("GetAllPodcast")]
        public async Task<ActionResult> GetAllPodcast()
        {
            _logger.LogInformation("Inside podcast controller (GetAllPodcast");
            var response = await _mediator.Send(new GetAllPodcastQuery());
            _logger.LogInformation("GetAllPodcast ActionMethod Completes");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetPodcastById")]
        public async Task<ActionResult> GetPodcastById(int id)
        {
            _logger.LogInformation("Inside podcast controller (GetPodcastById");
            var response = await _mediator.Send(new GetPodcastByIdQuery() { SectionMasterId = id});
            _logger.LogInformation("GetPodcastById ActionMethod Completes");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetChapterById")]
        public async Task<ActionResult> GetChapterById(int id)
        {
            var result = await _mediator.Send(new GetChapterByIdQuery() { ChapterId = id });
            return Ok(result);
        }
        
    }
}
