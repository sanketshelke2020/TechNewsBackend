using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Features.Articles.Queries.GetArticleById;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ArticleController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger<ArticleController> _logger;
        private readonly IArticleRepository _articleRepository;


        public ArticleController(IMediator mediator, ILogger<ArticleController> logger, IArticleRepository articleRepository)
        {
            _mediator = mediator;
            _logger = logger;
            _articleRepository = articleRepository;
        }
        [HttpGet]
        [Route("GetAllArticle")]
        public async Task<ActionResult> GetAllArticle()
        {
            _logger.LogInformation("GetAllArticle controller");
            var response = await _mediator.Send(new GetAllArticleQuery());
            _logger.LogInformation("GetAllArticle controller completed");
            return Ok(response);
        }



        [HttpGet]
        [Route("GetAllArticleCategory")]
        public async Task<ActionResult> GetAllArticleCategory()
        {
            var articleCategories = await _articleRepository.GetAllArticleCategory();
            return Ok(articleCategories);
        }
        [HttpGet]
        [Route("GetAllArticleSubCategory")]
        public async Task<ActionResult> GetAllArticleSubCategory(int ArticleCategoryID)
        {
            var articleSubCategories = await _articleRepository.GetAllArticleSubCategory(ArticleCategoryID);
            return Ok(articleSubCategories);
        }
        [HttpGet]
        [Route("GetArticleById")]
        public async Task<ActionResult> GetArticleById(int id)
        {
            _logger.LogInformation("GetArticleById controller");
            var response = await _mediator.Send(new GetArticleByIdQuery() { SectionMasterId = id});
            _logger.LogInformation("GetArticleById controller completed");
            return Ok(response);
        }

    }
}
