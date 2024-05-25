using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.Articles.Queries.GetArticleById
{
    public class GetArticleByIdQuery : IRequest<Response<GetArticleByIdQueryDto>>
    {
        public int SectionMasterId { get; set; }
    }
}
