using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Podcast.Queries.GetChapterById
{
    public class GetChapterByIdDto
    {
        public int? ChapterId { get; set; }
        public Byte[] Audio { get; set; }
        public string FileName { get; set; }
        public string ChapterTitle { get; set; }
        public int? ChapterNumber { get; set; }
        public string ChapterDescription { get; set; }
    }
}
