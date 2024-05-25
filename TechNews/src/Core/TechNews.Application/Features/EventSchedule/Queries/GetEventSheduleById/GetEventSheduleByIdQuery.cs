using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.EventSchedule.Queries.GetEventSheduleById
{
    public class GetEventSheduleByIdQuery:IRequest<Response<GetEventSheduleByIdDto>>
    {
        public int SectionMasterId { get; set; }
    }
}
