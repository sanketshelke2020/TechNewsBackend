using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Youtube.Queries.GetAllYoutube;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Webinar.Queries.GetAllWebinar
{
    public class GetAllWebinarQuery : IRequest<Response<List<GetAllWebinarQueryDto>>>
    {
    }
}
