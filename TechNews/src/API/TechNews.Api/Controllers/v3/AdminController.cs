using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Features.DynamicFields.Query.GetDynamicFieldByCategory;
using TechNews.Application.Features.Register.Command.AddUser;
using TechNews.Application.Features.SectionMasters.Commands.CreateSectionMaster;
using TechNews.Application.Features.SectionMasters.Commands.DeleteSectionMaster;
using TechNews.Application.Features.SectionMasters.Commands.UpdateSectionMaster;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByCategory;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterById;
using TechNews.Application.Features.UserQueries.Command;
using TechNews.Application.Features.UserQueries.Query.GetAllUserQuery;
using TechNews.Application.Features.UserQueries.Query.GetUserQueryById;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]

    public class AdminController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;

        public AdminController(IMediator mediator, ILogger<GuestUserController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }
        [HttpPost]
        [Route("AddSectionmaster")]
        //[Authorize]
        public async Task<ActionResult> Create(CreateSectionMasterCommand createSectionMaster)
        {
            _logger.LogInformation("AddSection Controller Initiated");
            var response = await _mediator.Send(createSectionMaster);
            _logger.LogInformation("AddSection Controller Completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetSectionMasterByCategory")]
        public async Task<ActionResult> GetSectionMasterByCategory(string category)
        
        {
            var response = await _mediator.Send(new GetSectionMasterByCategoryQuery() { CategoryType = category });
            return Ok(response);
        }
        [HttpDelete]
        [Route("DeleteSectionMaster")]
        public async Task<ActionResult> DeleteSectionMaster(int sectionMasterId)
        {
            _logger.LogInformation("DeleteSection Controller Initiated");
            var response = await _mediator.Send(new DeleteSectionMasterCommand() { SectionMasterId = sectionMasterId });
            _logger.LogInformation("DeleteSection Controller Completed");
            return Ok(response);
        }

        [HttpGet]
        [Route("GetSectionMasterById")]
        public async Task<ActionResult> GetSectionMasterById(int sectionMasterId)
        {
            _logger.LogInformation("GetSection Controller Initiated");
            var response = await _mediator.Send(new GetSectionMasterByIdQuery() {SectionMasterId = sectionMasterId });
            _logger.LogInformation("GetSection Controller Completed");
            return Ok(response);
        }
        [HttpPost]
        [Route("UpdateSectionMaster")]
        public async Task<ActionResult> UpdateSectionMaster(UpdateSectionMasterCommand updateSectionMasterCommand)
        {
            _logger.LogInformation("GetSection Controller Initiated");
            var response = await _mediator.Send(updateSectionMasterCommand);
            _logger.LogInformation("GetSection Controller Completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetAllUserQuery")]
        public async Task<ActionResult> GetAllUserQuery()
        {
            _logger.LogInformation("GetSection(GetAllUserQuery) Controller Initiated");
            var response = await _mediator.Send(new GetAllUserQueriesQuery());
            _logger.LogInformation("GetSection(GetAllUserQuery) Controller Completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetUserQueryById")]
        public async Task<ActionResult> GetUserQueryById(int id)
        {
            _logger.LogInformation("GetSection(GetUserQueryById) Controller Initiated");
            var response = await _mediator.Send(new GetUserQueryByIdQuery() { QuerieId = id});
            _logger.LogInformation("GetSection(GetUserQueryById) Controller Completed");
            return Ok(response);
        }

        [HttpPost]
        [Route("AddUserQuery")]

        public async Task<ActionResult> AddUserQuery(AddUserQueryCommand addUserQueryCommand)
        {

            _logger.LogInformation("Userquery Controller Initiated");
            var response = await _mediator.Send(addUserQueryCommand);

            _logger.LogInformation("Userquery Controller Completed");
            return Ok(response);

        }
        [HttpGet]
        [Route("GetDynamicFieldByCategory")]
        public async Task<ActionResult> GetDynamicFieldByCategory(string  category)
        {
            _logger.LogInformation("GetSection(GetDynamicFieldByCategory) Controller Initiated");
            var response = await _mediator.Send(new GetDynamicFieldByCategoryQueris() {CategoryType = category });
            _logger.LogInformation("GetSection(GetDynamicFieldByCategory) Controller Completed");
            return Ok(response);
        }
    }
}
