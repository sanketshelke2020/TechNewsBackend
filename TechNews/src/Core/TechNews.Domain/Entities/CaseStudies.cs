using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class CaseStudies
    {
        public int CaseStudiesId { get; set; }
        public int? NumberOfChapter { get; set; }
        public string? LongDescription { get; set; }

        public int SectionMasterId { get; set; }
        public virtual SectionMaster SectionMaster { get; set; }

    }
}
