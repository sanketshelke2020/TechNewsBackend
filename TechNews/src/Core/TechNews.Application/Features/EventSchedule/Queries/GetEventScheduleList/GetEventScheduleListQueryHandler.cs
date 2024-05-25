using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.EventSchedule.Queries.GetEventScheduleList;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.EventSchedule.Queries.GetEventScheduleList
{
    public class GetEventScheduleListQueryHandler:IRequestHandler<GetEventScheduleListQuery, Response<List<EventScheduleListVm>>>
    {
        private readonly IMapper _mapper;
        private readonly IEventScheduleRepository _eventScheduleRepository;
        private readonly ILogger<GetEventScheduleListQueryHandler> _logger;

        public GetEventScheduleListQueryHandler(IMapper mapper, IEventScheduleRepository eventScheduleRepository, ILogger<GetEventScheduleListQueryHandler> logger)
        {
            _mapper = mapper;
            _eventScheduleRepository = eventScheduleRepository;
            _logger = logger;
        }   


        public async Task<Response<List<EventScheduleListVm>>> Handle(GetEventScheduleListQuery request, CancellationToken cancellationToken)
        {
            List<SectionMaster> events = await _eventScheduleRepository.GetAllEventSchedule();
            var result = _mapper.Map<List<EventScheduleListVm>>(events);
            return new Response<List<EventScheduleListVm>>(result);
        }
    }
}
