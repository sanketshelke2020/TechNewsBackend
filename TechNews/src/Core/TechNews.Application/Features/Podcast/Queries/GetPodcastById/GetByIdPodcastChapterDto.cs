using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Podcast.Queries.GetPodcastById
{
    public class GetByIdPodcastChapterDto
    {
        public int? ChapterId { get; set; }
        public Byte[] Audio { get; set; }
        public string ChapterTitle { get; set; }
        public int? ChapterNumber { get; set; }
        public string ChapterDescription { get; set; }
        public int? PodcastId { get; set; }
    }
}
