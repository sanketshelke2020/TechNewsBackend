using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.HomePage.Queries.TreandingVideo
{
    public class GetTreandingVideoQuery:IRequest<Response<List<GetTreandingVideoDto>>>
    {
    }
}
