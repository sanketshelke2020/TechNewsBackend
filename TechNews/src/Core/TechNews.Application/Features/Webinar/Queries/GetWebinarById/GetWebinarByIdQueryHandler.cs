using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Youtube.Queries.GetYoutubeById;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Webinar.Queries.GetYoutubeById
{
    public class GetWebinarByIdQueryHandler : IRequestHandler<GetWebinarByIdQuery, Response<GetWebinarByIdQueryDto>>
    {
        private readonly ILogger<GetWebinarByIdQueryHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IWebinarRepository _webinarRepository;
        public GetWebinarByIdQueryHandler(ILogger<GetWebinarByIdQueryHandler> logger, IMapper mapper, IWebinarRepository webinarRepository)
        {
            _logger = logger;
            _mapper = mapper;
            _webinarRepository = webinarRepository;
        }

        public async Task<Response<GetWebinarByIdQueryDto>> Handle(GetWebinarByIdQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(" GetWebinarByIdQueryHandler Initaiated");
            var webinar = await _webinarRepository.GetWebinarById(request.SectionMasterId);
            var result = _mapper.Map<GetWebinarByIdQueryDto>(webinar);
            return new Response<GetWebinarByIdQueryDto>(result);
        }
    }
}
