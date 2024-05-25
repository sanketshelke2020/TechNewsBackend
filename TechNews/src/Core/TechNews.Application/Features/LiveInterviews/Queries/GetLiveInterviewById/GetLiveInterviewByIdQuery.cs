using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.LiveInterviews.Queries.GetLiveInterviewById
{
    public class GetLiveInterviewByIdQuery : IRequest<Response<GetLiveInterviewByIdDto>>
    {
        public int SectionMasterId { get; set; }
    }
}
