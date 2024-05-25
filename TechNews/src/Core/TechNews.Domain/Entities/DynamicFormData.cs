using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class DynamicFormData
    {
        public int DynamicFormDataId { get; set; }
        public string DynamicData { get; set; }
        public int SectionMasterId { get; set; }
        public int DynamicFieldId { get; set; }
        public DynamicField DynamicField { get; set; }
        public virtual SectionMaster SectionMaster { get; set; }
    }
}
