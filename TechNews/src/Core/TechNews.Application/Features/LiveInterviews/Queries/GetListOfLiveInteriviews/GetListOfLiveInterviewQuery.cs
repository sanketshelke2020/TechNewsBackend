using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.LiveInterviews.Queries.GetListOfLiveInteriviews
{
    public class GetListOfLiveInterviewQuery : IRequest<Response<List<GetLiveInterviewDto>>>
    {
    }
}
