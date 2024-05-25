using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class DynamicField
    {
        public int DynamicFieldId { get; set; }
        public string CategoryType { get; set; }
        public string LabelText { get; set; }
        public string? Options { get; set; }
        public string? PlaceHolder { get; set; }
        public int? MaxLength { get; set; }
        public int? MinLength { get; set; }
         public string FieldType { get; set; }
        public bool? IsNumber { get; set; } = false;
        public string FieldCode { get; set; }
        public virtual ICollection<DynamicFormMultipleOption>? DynamicFormMultipleOptions { get; set; }


    }
}
