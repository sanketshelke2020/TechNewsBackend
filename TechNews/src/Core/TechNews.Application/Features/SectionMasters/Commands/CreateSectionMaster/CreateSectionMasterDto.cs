using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.SectionMasters.Commands.CreateSectionMaster
{
    public class CreateSectionMasterDto
    {
        public int SectionMasterId { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
        public string ShortDescription { get; set; }
        public int TotalViews { get; set; }
        public string KeyWords { get; set; }
        public string CategoryType { get; set; }
        public string DynamicData { get; set; }
    }
}
