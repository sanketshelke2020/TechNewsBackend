using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.DynamicFields.Queries.GetAllDynamicField
{
    public class GetAllDynamicFieldQuery : IRequest<Response<List<GetAllDynamicFieldQueryDto>>>
    {
    }
}
