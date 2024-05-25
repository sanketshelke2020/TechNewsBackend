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

namespace TechNews.Application.Features.LiveInterviews.Queries.GetLiveInterviewById
{
    public class GetLiveInterviewByIdQueryHandler : IRequestHandler<GetLiveInterviewByIdQuery, Response<GetLiveInterviewByIdDto>>
    {
        private readonly ILiveInterviewRepository _liveInterviewRepository;
        private readonly IMapper _mapper;

        public GetLiveInterviewByIdQueryHandler(ILiveInterviewRepository liveInterviewRepository,IMapper mapper)
        {
            this._liveInterviewRepository = liveInterviewRepository;
            this._mapper = mapper;
        }
        public async Task<Response<GetLiveInterviewByIdDto>> Handle(GetLiveInterviewByIdQuery request, CancellationToken cancellationToken)
        {
            SectionMaster sectionMaster = await _liveInterviewRepository.GetLiveInterviewById(request.SectionMasterId);
            GetLiveInterviewByIdDto getLiveInterviewByIdDto = _mapper.Map<GetLiveInterviewByIdDto>(sectionMaster);
            return new Response<GetLiveInterviewByIdDto>(getLiveInterviewByIdDto);
        }
    }
}
