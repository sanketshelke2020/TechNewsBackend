using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.CaseStudies.Queries.GetAllCaseStudies;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Youtube.Queries.GetAllYoutube
{
    public class GetAllYoutubeQuery : IRequest<Response<List<GetAllYoutubeQueryDto>>>
    {
    }
}
