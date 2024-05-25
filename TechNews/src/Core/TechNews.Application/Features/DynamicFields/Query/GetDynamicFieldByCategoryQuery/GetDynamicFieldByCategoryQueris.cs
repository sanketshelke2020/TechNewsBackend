using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.DynamicFields.Query.GetDynamicFieldByCategoryQuery;

namespace TechNews.Application.Features.DynamicFields.Query.GetDynamicFieldByCategory
{
    public class GetDynamicFieldByCategoryQueris:IRequest<List<GetDynamicFieldByCategoryDto>>
    {
        public string CategoryType { get; set; }
    }
}
