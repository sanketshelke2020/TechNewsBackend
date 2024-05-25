using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.DynamicFields.Query.GetDynamicFieldByCategoryQuery
{
    public class MultipleOptionDto
    {
        public int DynamicFormMultipleOptionId { get; set; }
        public string FieldType { get; set; }
        public string OptionName { get; set; }
        public int DynamicFieldId { get; set; }
        
    }
}
