﻿using AutoMapper;
using TechNews.Application.Contracts.Infrastructure;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Events.Queries.GetEventsExport;
using TechNews.Application.Profiles;
using TechNews.Application.UnitTests.Mocks;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace TechNews.Application.UnitTests.Events.Queries
{
    public class GetEventsExportQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IEventRepository> _mockEventRepository;
        private readonly Mock<ICsvExporter> _csvExporter;

        public GetEventsExportQueryHandlerTests()
        {
            _mockEventRepository = EventRepositoryMocks.GetEventRepository();
            var configurationProvider = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
            _csvExporter = CsvExporterMocks.GetCsvExporter();
        }

        [Fact]
        public async Task Handle_GetEventsExport_FromEventsRepo()
        {
            var handler = new GetEventsExportQueryHandler(_mapper, _mockEventRepository.Object, _csvExporter.Object);

            var result = await handler.Handle(new GetEventsExportQuery(), CancellationToken.None);

            result.ShouldBeOfType<EventExportFileVm>();
            result.Data.ShouldNotBeEmpty();
        }
    }
}
