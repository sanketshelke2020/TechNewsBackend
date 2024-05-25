using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Chapters.Query.ChapterNumberExist
{
    public class ChapterNumberExistQuery:IRequest<Response<bool>>
    {
        public int ChapterNumber { get; set; }
        public int PodcastId { get; set; }
    }
}
