using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Features.Chapters.Command.AddChapter;
using TechNews.Application.Features.Chapters.Command.DeleteChapter;
using TechNews.Application.Features.Chapters.Command.UpdateChapter;
using TechNews.Application.Features.Chapters.Query.ChapterNumberExist;
using TechNews.Application.Features.Chapters.Query.GetAllChapterByPodcast;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ChapterController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public ChapterController(IMediator mediator, ILogger<ChapterController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpPost]
        [Route("AddChapter")]
        public async Task<ActionResult> AddChapter(AddChapterCommand addChapterCommand)
        {
            _logger.LogInformation("Inside ChapterController controller (AddComment");
            var response = await _mediator.Send(addChapterCommand);
            _logger.LogInformation("AddChapter ActionMethod Completes");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetChapterByPodcastId")]
        public async Task<ActionResult> GetChapterByPodcastId(int id)
        {
            _logger.LogInformation("Inside ChapterController controller (AddComment");
            var response = await _mediator.Send(new GetAllChapterByPodcastQuery() { PodcastId = id});
            _logger.LogInformation("AddChapter ActionMethod Completes");
            return Ok(response);
        }
        [HttpGet]
        [Route("DeleteChapter")]
        public async Task<ActionResult> DeleteChapter(int id)
        {
            _logger.LogInformation("Inside ChapterController controller (DeleteChapter");
            var response = await _mediator.Send(new DeleteChapterQuery() { ChapterId = id });
            _logger.LogInformation("DeleteChapter ActionMethod Completes");
            return Ok(response);
        }
        [HttpPost]
        [Route("UpdateChapter")]
        public async Task<ActionResult> UpdateChapter(UpdateChapterCommand updateChapterCommand )
        {
            _logger.LogInformation("Inside ChapterController controller (UpdateChapter");
            var response = await _mediator.Send(updateChapterCommand);
            _logger.LogInformation("UpdateChapter ActionMethod Completes");
            return Ok(response);
        }
        [HttpGet]
        [Route("ChapterNumberExist")]
        public async Task<ActionResult> ChapterNumberExist(int no ,int podcastId)
        {
            _logger.LogInformation("Inside ChapterController controller (ChapterNumberExist");
            var response = await _mediator.Send(new ChapterNumberExistQuery(){ChapterNumber = no,PodcastId = podcastId});
            _logger.LogInformation("ChapterNumberExist ActionMethod Completes");
            return Ok(response);
        }
    }
    
}
