using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.DynamicFields.Queries.GetFieldByCategory
{
    public class GetFieldByCategoryQuery : IRequest<Response<List<DynamicField>>>
    {
        public string CategoryType { get; set; }

    }
}
