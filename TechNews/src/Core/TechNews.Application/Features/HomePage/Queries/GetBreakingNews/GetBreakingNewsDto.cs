using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.HomePage.Queries.GetBreakingNews
{
    public class GetBreakingNewsDto
    {
        public int SectionMasterId { get; set; }
        public Byte[] Image { get; set; }
        public int ArticleId { get; set; }
        public string Title { get; set; }

        public int TotalViews { get; set; }
    }
}
