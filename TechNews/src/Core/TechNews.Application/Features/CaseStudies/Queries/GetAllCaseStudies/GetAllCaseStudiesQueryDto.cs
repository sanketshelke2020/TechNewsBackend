using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.CaseStudies.Queries.GetAllCaseStudies
{
    public class GetAllCaseStudiesQueryDto
    {
        public int CaseStudiesId { get; set; }
        public string? LongDescription { get; set; }

        public int SectionMasterId { get; set; }
        //public virtual SectionMaster SectionMaster { get; set; }
        public string Title { get; set; }
        public Byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public int? NumberOfChapter { get; set; }

        public int TotalViews { get; set; }
        public ICollection<CaseStudiesStoredFileDto> StoredFiles { get; set; }

    }
}
