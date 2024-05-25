using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.EventSchedule.Queries.GetEventSheduleById
{
    public class GetEventSheduleByIdQueryHandler : IRequestHandler<GetEventSheduleByIdQuery, Response<GetEventSheduleByIdDto>>
    {
        private readonly IMapper _mapper;
        private readonly IEventScheduleRepository _eventScheduleRepository;
        private readonly ILogger<GetEventSheduleByIdQueryHandler> _logger;

        public GetEventSheduleByIdQueryHandler(IMapper mapper, IEventScheduleRepository eventScheduleRepository, ILogger<GetEventSheduleByIdQueryHandler> logger)
        {
            _mapper = mapper;
            _eventScheduleRepository = eventScheduleRepository;
            _logger = logger;
        }
        public  async Task<Response<GetEventSheduleByIdDto>> Handle(GetEventSheduleByIdQuery request, CancellationToken cancellationToken)
        {
            var eventshedule = await _eventScheduleRepository.GetEventSheduleById(request.SectionMasterId);
            var response = _mapper.Map<GetEventSheduleByIdDto>(eventshedule);
            if(response != null)
            {
                if (response.EventDate > DateTime.Now)
                {
                    response.YoutubeVideoLink = null;
                }
            }
          
            return new Response<GetEventSheduleByIdDto>(response);
        }
    }
}
