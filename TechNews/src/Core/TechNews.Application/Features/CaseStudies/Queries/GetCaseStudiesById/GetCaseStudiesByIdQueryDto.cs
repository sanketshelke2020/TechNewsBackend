using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Features.CaseStudies.Queries.GetAllCaseStudies;

namespace TechNews.Application.Features.CaseStudies.Queries.GetCaseStudiesById
{
    public class GetCaseStudiesByIdQueryDto
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
        public ICollection<GetCaseStudiesByIdStoredFileDto> StoredFiles { get; set; }
        public ICollection<GetCaseStudiesByIdCommentDto>? Comments { get; set; }

    }
}
