using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.EventSchedule.Queries.GetEventScheduleList
{
    public class EventScheduleListVm
    {
        public int SectionMasterId { get; set; }
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public int TotalViews { get; set; }
        public string KeyWords { get; set; }
        public string CategoryType { get; set; }
        public int EventScheduleID { get; set; }
        public string EventTopic { get; set; }
        public DateTime? EventDate { get; set; }
        public string SpeakerName { get; set; }
        public string? YoutubeVideoLink { get; set; }
        
    }
}
