﻿using AutoMapper;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Events.Queries.GetEventDetail;
using TechNews.Application.Features.Events.Queries.GetEventsList;
using TechNews.Application.Profiles;
using TechNews.Application.Responses;
using TechNews.Application.UnitTests.Mocks;
using TechNews.Domain.Entities;
using Microsoft.Extensions.Logging;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace TechNews.Application.UnitTests.Event.Queries
{
    public class GetEventListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IEventRepository> _mockEventRepository;

        public GetEventListQueryHandlerTests()
        {
            _mockEventRepository = EventRepositoryMocks.GetEventRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });
            _mapper = configurationProvider.CreateMapper();
        }

       
      //  [Fact]
        public async Task Handle_GetEventList_FromEventsRepo()
        {
            var handler = new GetEventsListQueryHandler(_mapper, _mockEventRepository.Object);

            var result = await handler.Handle(new GetEventsListQuery(), CancellationToken.None);

            result.ShouldBeOfType<Response<IEnumerable<EventListVm>>>();
            result.Data.ShouldNotBeEmpty();
        }
    }
}
