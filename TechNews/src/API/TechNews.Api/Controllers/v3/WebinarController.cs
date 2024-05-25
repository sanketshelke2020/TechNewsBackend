using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Register.Command.AddUser;
using TechNews.Application.Features.Webinar.Command;
using TechNews.Application.Features.Webinar.Queries.GetAllWebinar;
using TechNews.Application.Features.Webinar.Queries.GetYoutubeById;
using TechNews.Application.Features.Youtube.Queries.GetAllYoutube;
using TechNews.Application.Features.Youtube.Queries.GetYoutubeById;
using TechNews.Application.Models.Mail;
using TechNews.Domain.Entities;
using TechNews.Persistence.Repositories;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class WebinarController : ControllerBase
    {

        private readonly IMediator _mediator;
        private readonly ILogger<WebinarController> _logger;
        private readonly IWebinarRepository _webinarRepository ;
        private readonly IEnrollmentRepository _enrollmentRepository ;
        public WebinarController(IMediator mediator, ILogger<WebinarController> logger, IWebinarRepository webinarRepository, IEnrollmentRepository enrollmentRepository)
        {
            _mediator = mediator;
            _logger = logger;
            _webinarRepository = webinarRepository;
            _enrollmentRepository = enrollmentRepository;
        }
        [HttpGet]
        [Route("GetAllWebinar")]

        public async Task<ActionResult> GetAllWebinar()
        {
            _logger.LogInformation("GetAllWebinar controller");
            var response = await _mediator.Send(new GetAllWebinarQuery());
            _logger.LogInformation("GetAllWebinar controller completed");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetWebinarById")]
        public async Task<ActionResult> GetWebinarById(int id)
        {
            _logger.LogInformation("GetWebinarById controller");
            var response = await _mediator.Send(new GetWebinarByIdQuery() { SectionMasterId = id });
            _logger.LogInformation("GetWebinarById controller completed");
            return Ok(response);
        }
        [HttpPost]
        [Route("AddEnrollment")]

        public async Task<ActionResult> AddEnrollment(AddEnrollmentCommand add )
        {
            _logger.LogInformation("EnrollmentController Initiated");
            var response = await _mediator.Send(add);
            _logger.LogInformation("EnrollmentController Completed");
            //if(response != null)
            //{
            //    response.Succeeded = true;
            //}
            //else
            //{
            //    response.Succeeded = false;
            //}
            return Ok(response);
        }
        [HttpGet]
        [Route("EnrollmentExist")]
        public async Task<ActionResult> EnrollmentDone(int userId, int webinarId)
        {
            
                var roles = await _enrollmentRepository.EnrollmentDone(userId,webinarId);
                return Ok(roles);
            
        }
        [HttpGet]
        [Route("GetAllEnrolledUser")]
        public async Task<ActionResult> GetAllEnrolledUser(int WebinarId)
        {
            var enrolls= await _enrollmentRepository.GetAllEnrolledUser(WebinarId);
            return Ok(enrolls);
        }




    }
}
