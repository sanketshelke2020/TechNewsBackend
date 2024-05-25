using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Podcast.Queries.GetPodcastById;

namespace TechNews.Application.Features.LiveInterviews.Queries.GetLiveInterviewById
{
    public class GetLiveInterviewByIdDto
    {
        public int SectionMasterId { get; set; }
        public string Title { get; set; }
        public Byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public int TotalViews { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LiveInterviewId { get; set; }
        public string? LongDescription { get; set; }
        public string? YoutubeVideoLink { get; set; }
        public ICollection<LiveInterviewCommentDto>? Comments { get; set; }
    }
}
