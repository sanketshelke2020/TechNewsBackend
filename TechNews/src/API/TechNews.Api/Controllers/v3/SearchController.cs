using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Features.LiveInterviews.Queries.GetListOfLiveInteriviews;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByKeyword;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public SearchController(IMediator mediator, ILogger<SearchController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        [HttpGet]
        [Route("GetSectionByKeyword")]
        public async Task<ActionResult> GetSectionByKeyword(string searchKeyword)
        {
            _logger.LogInformation("Inside GetSectionByKeyword controller ");
            var response = await _mediator.Send(new GetSectionMasterByKeywordQuery() { SearchKeyword = searchKeyword});
            _logger.LogInformation("GetSectionByKeyword ActionMethod Completes");
            return Ok(response);
        }
    }
}
