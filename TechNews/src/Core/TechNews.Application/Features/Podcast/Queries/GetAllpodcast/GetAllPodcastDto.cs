using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Podcast.Queries.GetAllpodcast
{
    public class GetAllPodcastDto
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
        public ICollection<PodcastChapterDto> Chapters { get; set; }
        public ICollection<PodcastCommentDto> Comment { get; set; }

        public DateTime CreatedDate { get; set; }

        //public ICollection<PodcastStoreFileDto>? StoredFiles { get; set; }



    }
}
