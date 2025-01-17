﻿using TechNews.Application.Features.Categories.Commands.CreateCategory;
using TechNews.Application.Features.Categories.Commands.StoredProcedure;
using TechNews.Application.Features.Categories.Queries.GetCategoriesList;
using TechNews.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using TechNews.Application.Features.Events.Commands.CreateEvent;
using TechNews.Application.Features.Events.Commands.DeleteEvent;
using TechNews.Application.Features.Events.Commands.Transaction;
using TechNews.Application.Features.Events.Commands.UpdateEvent;
using TechNews.Application.Features.Events.Queries.GetEventDetail;
using TechNews.Application.Features.Events.Queries.GetEventsExport;
using TechNews.Application.Features.Events.Queries.GetEventsList;
using TechNews.Application.Features.Orders.GetOrdersForMonth;
using TechNews.Application.Responses;
using MediatR;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace TechNews.API.UnitTests.Mocks
{
    public class MediatorMocks
    {
        public static Mock<IMediator> GetMediator()
        {
            var mockMediator = new Mock<IMediator>();

            mockMediator.Setup(m => m.Send(It.IsAny<GetCategoriesListQuery>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Response<IEnumerable<CategoryListVm>>());
            mockMediator.Setup(m => m.Send(It.IsAny<GetCategoriesListWithEventsQuery>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Response<IEnumerable<CategoryEventListVm>>());
            mockMediator.Setup(m => m.Send(It.IsAny<CreateCategoryCommand>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Response<CreateCategoryDto>());
            mockMediator.Setup(m => m.Send(It.IsAny<StoredProcedureCommand>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Response<StoredProcedureDto>());

            mockMediator.Setup(m => m.Send(It.IsAny<GetEventsListQuery>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Response<IEnumerable<EventListVm>>());
            mockMediator.Setup(m => m.Send(It.IsAny<GetEventDetailQuery>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Response<EventDetailVm>());
            mockMediator.Setup(m => m.Send(It.IsAny<GetEventsExportQuery>(), It.IsAny<CancellationToken>())).ReturnsAsync(new EventExportFileVm() { Data = Encoding.UTF8.GetBytes(new string(' ', 100)), ContentType = "text/csv", EventExportFileName = "Filename"  });
            mockMediator.Setup(m => m.Send(It.IsAny<CreateEventCommand>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Response<Guid>());
            mockMediator.Setup(m => m.Send(It.IsAny<UpdateEventCommand>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Response<Guid>());
            mockMediator.Setup(m => m.Send(It.IsAny<DeleteEventCommand>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Unit());
            mockMediator.Setup(m => m.Send(It.IsAny<TransactionCommand>(), It.IsAny<CancellationToken>())).ReturnsAsync(new Response<Guid>());

            mockMediator.Setup(m => m.Send(It.IsAny<GetOrdersForMonthQuery>(), It.IsAny<CancellationToken>())).ReturnsAsync(new PagedResponse<IEnumerable<OrdersForMonthDto>>(null, 10, 1, 2));
            
            return mockMediator;
        }
    }
}
