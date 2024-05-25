using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.UserQueries.Query.GetAllUserQuery
{
    public class GetAllUserQueriesQuery:IRequest<Response<List<GetAllUserQueriesDto>>>
    {
    }
}
