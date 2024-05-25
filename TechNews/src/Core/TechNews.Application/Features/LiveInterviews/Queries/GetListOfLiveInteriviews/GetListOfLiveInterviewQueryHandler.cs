using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.LiveInterviews.Queries.GetListOfLiveInteriviews
{
    public class GetListOfLiveInterviewQueryHandler : IRequestHandler<GetListOfLiveInterviewQuery, Response<List<GetLiveInterviewDto>>>
    {
        private readonly ISectionMasterRepository _sectionMasterRepository;
        private readonly IMapper _mapper;

        public GetListOfLiveInterviewQueryHandler(ISectionMasterRepository sectionMasterRepository, IMapper mapper)
        {
            this._sectionMasterRepository = sectionMasterRepository;
            this._mapper = mapper;
        }
        public async Task<Response<List<GetLiveInterviewDto>>> Handle(GetListOfLiveInterviewQuery request, CancellationToken cancellationToken)
        {
            List<SectionMaster> section = await _sectionMasterRepository.GetSectionMasterByCategory("LiveInterview");
            List<GetLiveInterviewDto> getLiveInterviewDtos = _mapper.Map<List<GetLiveInterviewDto>>(section);
            return new Response<List<GetLiveInterviewDto>>(getLiveInterviewDtos);
        }
    }
}
