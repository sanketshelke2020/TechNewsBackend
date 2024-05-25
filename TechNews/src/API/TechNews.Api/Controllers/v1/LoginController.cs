using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Contracts.Infrastructure;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Models.Authentication;

namespace TechNews.Api.Controllers.v1
{
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _authService;
        private readonly IMapper _mapper;
        

        public LoginController(ILoginService authService, IMapper mapper)
        {
            _authService = authService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> LoginUser(LoginUserViewModel model)
        {
            try
            {
                AuthenticationResponse response = await _authService.Login(model.Email, model.Password);
                if (response != null)
                {
                    return Ok(response);
                }
                return BadRequest(new AuthenticationResponse() { Message = "Failed to Login user", IsAuthenticated = false, Token = null, Role = null }); ;

            }
            catch (Exception e)
            {
                return BadRequest(new AuthenticationResponse() { Message = e.Message, IsAuthenticated = false, Token = null, Role = null,Id = null });
            }

        }
    }
}
