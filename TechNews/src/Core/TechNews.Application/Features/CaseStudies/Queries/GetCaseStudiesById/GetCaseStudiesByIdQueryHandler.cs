using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Features.CaseStudies.Queries.GetAllCaseStudies;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.CaseStudies.Queries.GetCaseStudiesById
{
    public class GetCaseStudiesByIdQueryHandler : IRequestHandler<GetCaseStudiesByIdQuery, Response<GetCaseStudiesByIdQueryDto>>
    {
        private readonly ILogger<GetCaseStudiesByIdQueryHandler> _logger;
        private readonly ICaseStudiesRepository _caseStudiesRepository;
        private readonly IMapper _mapper;
        public GetCaseStudiesByIdQueryHandler(ILogger<GetCaseStudiesByIdQueryHandler> logger, ICaseStudiesRepository  caseStudiesRepository, IMapper mapper)
        {
            _logger = logger;
            _caseStudiesRepository = caseStudiesRepository;
            _mapper = mapper;
        }
        public async Task<Response<GetCaseStudiesByIdQueryDto>> Handle(GetCaseStudiesByIdQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(" GetCaseStudiesByIdQueryHandler Initaiated");
            var cs = await _caseStudiesRepository.GetCaseStudiesById(request.SectionMasterId);
            var result = _mapper.Map<GetCaseStudiesByIdQueryDto>(cs);
            return new Response<GetCaseStudiesByIdQueryDto>(result);
        }
    }
}
