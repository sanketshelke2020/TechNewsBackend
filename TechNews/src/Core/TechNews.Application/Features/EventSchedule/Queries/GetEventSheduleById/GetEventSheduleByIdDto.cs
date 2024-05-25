using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.EventSchedule.Queries.GetEventSheduleById
{
    public class GetEventSheduleByIdDto
    {
        public int SectionMasterId { get; set; }    
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int TotalViews { get; set; }
        public string KeyWords { get; set; }
        public string CategoryType { get; set; }
        public int EventScheduleID { get; set; }
        public string EventTopic { get; set; }
        public DateTime? EventDate { get; set; }
        public string SpeakerName { get; set; }
        public string? YoutubeVideoLink { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<GetEventSheduleByIdCommentDto> Comments { get; set; }
    }
}
