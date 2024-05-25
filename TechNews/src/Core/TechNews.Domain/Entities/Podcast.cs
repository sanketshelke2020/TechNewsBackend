using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class Podcast
    {
        public int PodcastId { get; set; }
        public string? SpeakerName { get; set; }
        public string? LongDescription { get; set; }

        public int SectionMasterId { get; set; }
        public virtual SectionMaster SectionMaster { get; set; }
        public ICollection<Chapter> Chapters { get; set; }

    }
}
