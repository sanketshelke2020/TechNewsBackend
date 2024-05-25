using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Articles.Queries.GetAllArticle
{
    public class GetAllArticleQuery: IRequest<Response<List<GetAllArticleQueryDto>>>
    { 
        
    }
}
