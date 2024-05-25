using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Youtube.Queries.GetAllYoutube;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.Webinar.Queries.GetAllWebinar
{
    public class GetAllWebinarQueryHandler : IRequestHandler<GetAllWebinarQuery, Response<List<GetAllWebinarQueryDto>>>
    {
        private readonly ILogger<GetAllWebinarQueryHandler> _logger;
        private readonly IWebinarRepository _webinarRepository;
        private readonly IMapper _mapper;
        public GetAllWebinarQueryHandler(ILogger<GetAllWebinarQueryHandler> logger, IWebinarRepository webinarRepository, IMapper mapper)
        {
            _logger = logger;
            _webinarRepository = webinarRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetAllWebinarQueryDto>>> Handle(GetAllWebinarQuery request, CancellationToken cancellationToken)
        {
            List<SectionMaster> sectionMasters = await _webinarRepository.GetAllWebinar();
            var result = _mapper.Map<List<GetAllWebinarQueryDto>>(sectionMasters);
            return new Response<List<GetAllWebinarQueryDto>>(result);
        }
    }
}
