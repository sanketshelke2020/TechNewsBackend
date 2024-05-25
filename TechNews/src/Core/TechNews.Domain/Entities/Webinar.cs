using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class Webinar
    {
        public int WebinarId { get; set; }
         public string Topic { get; set; }
        public string SpeakerName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TotalSeat { get; set; }
        public string LongDescription { get; set; }
        public string? YoutubeVideoLink { get; set; }
        public int SectionMasterId { get; set; }
        public virtual SectionMaster SectionMaster { get; set; }

        public ICollection<WebinarHolder> WebinarHolders { get; set; }
        public ICollection<Enrollment>? Enrollments { get; set; }

    }
}
