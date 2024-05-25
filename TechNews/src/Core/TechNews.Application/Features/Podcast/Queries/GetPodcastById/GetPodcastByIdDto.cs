using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Podcast.Queries.GetPodcastById
{
    public class GetPodcastByIdDto
    {
        public int SectionMasterId { get; set; }
        public string Title { get; set; }
        public Byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public int TotalViews { get; set; }
        public string KeyWords { get; set; }
        public string CategoryType { get; set; }
        public int PodcastId { get; set; }
        public string SpeakerName { get; set; }
        public string LongDescription { get; set; }     
        public ICollection<GetByIdPodcastChapterDto> Chapters { get; set; }
        public ICollection<GetPodcastByIdCommentDto> Comment { get; set; }
    }
}
