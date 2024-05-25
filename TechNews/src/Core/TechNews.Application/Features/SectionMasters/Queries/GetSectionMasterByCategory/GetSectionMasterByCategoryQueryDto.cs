using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByCategory
{
    public class GetSectionMasterByCategoryQueryDto
    {
        public int SectionMasterId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public int TotalViews { get; set; }
        public string KeyWords { get; set; }
        public string CategoryType { get; set; }
        public byte[] ?ImageFile { get; set; }
       

    }
}
