using TechNews.Application.Responses;
using MediatR;
using System.Collections.Generic;

namespace TechNews.Application.Features.Events.Queries.GetEventsList
{
    public class GetEventsListQuery: IRequest<Response<IEnumerable<EventListVm>>>
    {

    }
}
