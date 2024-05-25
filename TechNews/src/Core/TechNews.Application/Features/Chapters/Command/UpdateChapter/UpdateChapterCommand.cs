using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Chapters.Command.UpdateChapter
{
    public class UpdateChapterCommand:IRequest<Response<UpdateCommandDto>>
    {
        public int ChapterId { get; set; }
        public byte[]? Audio { get; set; }
        public string FileName { get; set; }
        public string? ChapterTitle { get; set; }
        public int? ChapterNumber { get; set; }
        public string? ChapterDescription { get; set; }
        public int PodcastId { get; set; }
    }
}
