﻿using AutoMapper;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQueryHandler : IRequestHandler<GetEventsListQuery, Response<IEnumerable<EventListVm>>>
    {
        private readonly IAsyncRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventsListQueryHandler(IMapper mapper, IAsyncRepository<Event> eventRepository)
        {
            _mapper = mapper;
            _eventRepository = eventRepository;
        }

        public async Task<Response<IEnumerable<EventListVm>>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAllAsync()).OrderBy(x => x.Date);
            var eventList = _mapper.Map<List<EventListVm>>(allEvents);
            var response = new Response<IEnumerable<EventListVm>>(eventList);
            return response;
        }
    }
}
