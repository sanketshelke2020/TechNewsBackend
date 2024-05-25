using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.CaseStudies.Queries.GetAllCaseStudies
{
    public class GetAllCaseStudiesQueryHandler : IRequestHandler<GetAllCaseStudiesQuery, Response<List<GetAllCaseStudiesQueryDto>>>
    {
        private readonly ILogger<GetAllCaseStudiesQueryHandler> _logger;
        private readonly ICaseStudiesRepository  _caseStudiesRepository;
        private readonly IMapper _mapper;
        public GetAllCaseStudiesQueryHandler(ILogger<GetAllCaseStudiesQueryHandler> logger, ICaseStudiesRepository caseStudiesRepository, IMapper mapper)
        {
            _logger = logger;
            _caseStudiesRepository = caseStudiesRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetAllCaseStudiesQueryDto>>> Handle(GetAllCaseStudiesQuery request, CancellationToken cancellationToken)
        {
            List<SectionMaster> sectionMasters = await _caseStudiesRepository.GetAllCaseStudies();
            var result = _mapper.Map<List<GetAllCaseStudiesQueryDto>>(sectionMasters);
            return new Response<List<GetAllCaseStudiesQueryDto>>(result);


        }
       
    }
}
