using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Podcast.Queries.GetPodcastById
{
    public class GetPodcastByIdQuery:IRequest<Response<GetPodcastByIdDto>>
    {
        public int SectionMasterId { get; set; }
       
    }
}
