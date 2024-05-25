using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Chapters.Query.GetAllChapterByPodcast
{
    public class GetAllChapterByPodcastQuery:IRequest<Response<List<GetAllChapterByPodcastDto>>>
    {
        public int PodcastId { get; set; }
    }
}
