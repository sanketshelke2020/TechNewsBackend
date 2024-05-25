using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Youtube.Queries.GetYoutubeById;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Webinar.Queries.GetYoutubeById
{
    public class GetWebinarByIdQuery : IRequest<Response<GetWebinarByIdQueryDto>>
    {
        public int SectionMasterId { get; set; }

    }
}
