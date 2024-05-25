using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Features.CaseStudies.Queries.GetAllCaseStudies;
using TechNews.Application.Features.CaseStudies.Queries.GetCaseStudiesById;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CaseStudiesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<CaseStudiesController> _logger;
        private readonly ICaseStudiesRepository _caseStudiesRepository;
        public CaseStudiesController(IMediator mediator, ILogger<CaseStudiesController> logger, ICaseStudiesRepository caseStudiesRepository)
        {
            _mediator = mediator;
            _logger = logger;
            _caseStudiesRepository = caseStudiesRepository;
        }
        [HttpGet]
        [Route("GetAllCaseStudies")]
        public async Task<ActionResult> GetAllCaseStudies()
        {
            _logger.LogInformation("GetAllCaseStudies controller");
            var response = await _mediator.Send(new GetAllCaseStudiesQuery());
            _logger.LogInformation("GetAllCaseStudies controller completed");
            return Ok(response);
        }

        [HttpGet]
        [Route("GetCaseStudiesById")]
        public async Task<ActionResult> GetCaseStudiesById(int id)
        {
            _logger.LogInformation("GetCaseStudiesById controller");
            var response = await _mediator.Send(new GetCaseStudiesByIdQuery() { SectionMasterId = id });
            _logger.LogInformation("GetCaseStudiesById controller completed");
            return Ok(response);
        }
    }
}
