using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.EventSchedule.Queries.GetEventScheduleList
{
    public class GetEventScheduleListQuery: IRequest<Response<List<EventScheduleListVm>>>
    {

    }
}
