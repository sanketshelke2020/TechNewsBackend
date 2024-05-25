using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByCategory
{
    public class GetSectionMasterByCategoryQuery:IRequest<Response<List<GetSectionMasterByCategoryQueryDto>>>
    {
        public string CategoryType { get; set; }
    }
}
