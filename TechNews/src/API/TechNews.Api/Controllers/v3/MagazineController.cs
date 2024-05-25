using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechNews.Application.Features.Magazines.Query.GetAllMagazine;
using TechNews.Application.Features.Magazines.Query.GetMagazineById;

namespace TechNews.Api.Controllers.v3
{
    [ApiVersion("3")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class MagazineController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly ILogger _logger;
       
        public MagazineController(IMediator mediator, ILogger<MagazineController> logger)
        {
            _mediator = mediator;
            _logger = logger;
         
        }
        [HttpGet]
        [Route("GetAllMagazine")]
        public async Task<ActionResult> GetAllMagazine()
        {
            _logger.LogInformation("Inside MagazineController controller (GetAllMagazine");
            var response = await _mediator.Send(new GetAllMagazineQuery());
            _logger.LogInformation("GetAllMagazine ActionMethod Completes");
            return Ok(response);
        }
        [HttpGet]
        [Route("GetAllMagazineById")]
        public async Task<ActionResult> GetAllMagazineById(int id)
        {
            _logger.LogInformation("Inside MagazineController controller (GetAllMagazine");
            var response = await _mediator.Send(new GetMgazineByIdQuery() { SectionMasterId = id});
            _logger.LogInformation("GetAllMagazine ActionMethod Completes");
            return Ok(response);
        }
    }
}
