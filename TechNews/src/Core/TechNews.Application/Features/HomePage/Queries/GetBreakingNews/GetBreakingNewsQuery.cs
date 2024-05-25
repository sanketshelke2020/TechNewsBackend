using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.HomePage.Queries.GetBreakingNews
{
    public class GetBreakingNewsQuery: IRequest<Response<List<GetBreakingNewsDto>>>
    {
    }
}
