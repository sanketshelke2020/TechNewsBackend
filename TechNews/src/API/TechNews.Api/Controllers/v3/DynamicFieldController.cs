using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Features.DynamicFields.Command.AddDynamicField;
using TechNews.Application.Features.DynamicFields.Command.DeleteDynamicField;
using TechNews.Application.Features.DynamicFields.Command.UpdateDynamicField;
using TechNews.Application.Features.DynamicFields.Queries.GetAllDynamicField;
using TechNews.Application.Features.DynamicFields.Queries.GetDynamicFieldById;
using TechNews.Application.Features.DynamicFields.Queries.GetFieldByCategory;
using TechNews.Application.Features.Register.Command.AddUser;
using TechNews.Application.Features.SectionMasters.Commands.DeleteSectionMaster;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class DynamicFieldController : ControllerBase
    {
        private readonly IDynamicFieldRepository _dynamicFieldRepository;
        private readonly ILogger<DynamicFieldController> _logger;
        private readonly IMediator _mediator;

        public DynamicFieldController(IDynamicFieldRepository dynamicFieldRepository, ILogger<DynamicFieldController> logger, IMediator mediator)
        {
            _dynamicFieldRepository = dynamicFieldRepository;
            _logger = logger;
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult> AddDynamicField(AddDynamicFieldCommand addDynamicFieldCommand)
        {

            _logger.LogInformation("DynamicFieldController Initiated");
            var response = await _mediator.Send(addDynamicFieldCommand);

            _logger.LogInformation("DynamicFieldController Completed");
            return Ok(response);

        }
         [HttpGet]
        [Route("GetFieldByCategory")]
        public async Task<ActionResult> GetFieldByCategory(string CategoryType)
        {
            _logger.LogInformation("GetFieldByCategory controller");
            var response = await _mediator.Send(new GetFieldByCategoryQuery() { CategoryType=CategoryType });
            _logger.LogInformation("GetArticleBGetFieldByCategoryId controller completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetAllDynamicField")]
        public async Task<ActionResult> GetAllDynamicField()
        {
            _logger.LogInformation("GetAllDynamicField controller");
            var response = await _mediator.Send(new GetAllDynamicFieldQuery());
            _logger.LogInformation("GetAllDynamicField controller completed");
            return Ok(response);
        }
        [HttpDelete]
        [Route("DeleteDynamicField")]
        public async Task<ActionResult> DeleteDynamicField(int DynamicFieldId)
        {
            _logger.LogInformation("DeleteDynamicField Controller Initiated");
            var response = await _mediator.Send(new DeleteDynamicFieldCommand() { DynamicFieldId=DynamicFieldId });
            _logger.LogInformation("DeleteDynamicField Controller Completed");
            return Ok(response);
        }
        [HttpPut]
        [Route("UpdateDynamicField")]
        public async Task<ActionResult> UpdateDynamicField(UpdateDynamicFieldCommand update)
        {
            _logger.LogInformation("UpdateDynamicField Controller Initiated");
            var response = await _mediator.Send(update);
            _logger.LogInformation("UpdateDynamicField Controller Completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetDynamicFieldById")]
        public async Task<ActionResult> GetDynamicFieldById(int DynamicFieldId)
        {
            _logger.LogInformation("GetDynamicFieldById Controller Initiated");
            var response = await _mediator.Send(new GetDynamicFieldByIdQuerie() { DynamicFieldId = DynamicFieldId });
            _logger.LogInformation("GetDynamicFieldById Controller Completed");
            return Ok(response);
        }
    }
}
