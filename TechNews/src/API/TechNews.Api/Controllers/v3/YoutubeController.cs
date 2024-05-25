using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Features.Youtube.Queries.GetAllYoutube;
using TechNews.Application.Features.Youtube.Queries.GetYoutubeById;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class YoutubeController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ILogger<YoutubeController> _logger;
        private readonly IYoutubeRepository _youtubeRepository;
        public YoutubeController(IMediator mediator, ILogger<YoutubeController> logger, IYoutubeRepository youtubeRepository)
        {
            _mediator = mediator;
            _logger = logger;
            _youtubeRepository = youtubeRepository;
        }
        [HttpGet]
        [Route("GetAllYoutube")]

        public async Task<ActionResult> GetAllYoutube()
        {
            _logger.LogInformation("GetAllYoutube controller");
            var response = await _mediator.Send(new GetAllYoutubeQuery());
            _logger.LogInformation("GetAllYoutube controller completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetYoutubeById")]
        public async Task<ActionResult> GetYoutubeById(int id)
        {
            _logger.LogInformation("GetYoutubeById controller");
            var response = await _mediator.Send(new GetYoutubeByIdQuery() { SectionMasterId = id });
            _logger.LogInformation("GetYoutubeById controller completed");
            return Ok(response);
        }
    }
}
