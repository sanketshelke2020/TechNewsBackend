using IdentityModel.OidcClient;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Register.Command.AddUser;
using TechNews.Application.Features.Register.Command.UpdateUser;
using TechNews.Application.Features.Register.Query.GetUserById;

namespace TechNews.Api.Controllers.v1
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IRegisterRepository _registerRepository;
        private readonly ILogger<RegisterController> _logger;
        private readonly IMediator _mediator;
        public RegisterController(ILogger<RegisterController> logger, IMediator mediator, IRegisterRepository registerRepository)
        {
            _logger= logger;
            _mediator= mediator;
            _registerRepository= registerRepository;
        }
        [HttpPost]
        public async Task<ActionResult> AddUser(AddUserCommand addUserCommand)
        {

            _logger.LogInformation("UserController Initiated");
            var response = await _mediator.Send(addUserCommand);
            
            _logger.LogInformation("UserController Completed");
            return Ok(response);

        }
        [HttpGet]
        [Route("GetAllCountry")]
        public async Task<ActionResult> GetAllCountry()
        {
            var roles = await _registerRepository.GetAllCountry();
            return Ok(roles);
        }
        [HttpGet]
        [Route("GetAllState")]
        public async Task<ActionResult> GetAllState(int countryId)
        {
            var roles = await _registerRepository.GetAllState(countryId);
            return Ok(roles);
        }

        [HttpGet]
        [Route("GetAllCity")]
        public async Task<ActionResult> GetAllCity(int stateId)
        {
            var roles = await _registerRepository.GetAllCity(stateId);
            return Ok(roles);
        }
        [HttpGet]
        [Route("EmailsDoesNotExists")]
        public async Task<ActionResult> EmailsDoesNotExists(string email)
        {
            var roles = await _registerRepository.EmailsDoesNotExists(email);
            return Ok(roles);
        }
        [HttpGet]
        [Route("GetAllUserRoles")]
        public async Task<ActionResult> GetAllUserRole()
        {
            var roles = await _registerRepository.GetAllUserRoles();
            return Ok(roles);
        }
        [HttpPost]
        [Route("UpdateUser")]
        public async Task<ActionResult> UpdateUser(UpdateUserCommand updateUserCommand)
        {
            _logger.LogInformation("UserController Initiated");
            var response = await _mediator.Send(updateUserCommand);
            _logger.LogInformation("UserController Completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetUserById")]
        public async Task<ActionResult> GetUserById(int id)
        {
            _logger.LogInformation("UserController Initiated (GetUserById)");
            var response = await _mediator.Send(new GetUserByIdQuery() { UserId = id});
            _logger.LogInformation("UserController Completed (GetUserById)");
            return Ok(response);
        }


    }
}
