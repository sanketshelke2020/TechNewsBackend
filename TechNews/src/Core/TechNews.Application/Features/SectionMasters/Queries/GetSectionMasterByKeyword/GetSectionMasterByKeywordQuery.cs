using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByKeyword
{
    public class GetSectionMasterByKeywordQuery : IRequest<Response<List<GetSectionMasterByKeywordDto>>>
    {
        public string? SearchKeyword { get; set; }
    }
}
