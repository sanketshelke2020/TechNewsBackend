using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Common;

namespace TechNews.Domain.Entities
{
    public class EventSchedule
    {
        public int EventScheduleId { get; set; }
        public string? EventTopic { get; set; }
        public DateTime? EventDate { get; set; }
        public string? SpeakerName { get; set; }
        public string? LongDescription { get; set; }

        public int SectionMasterId { get; set; }
        public string? YoutubeVideoLink { get; set; }
        public virtual SectionMaster SectionMaster { get; set; }
    }
}
