using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Chapters.Command.DeleteChapter
{
    public class DeleteChapterQuery:IRequest<Response<DeleteChapterDto>>
    {
        public int ChapterId { get; set; }
    }
}
