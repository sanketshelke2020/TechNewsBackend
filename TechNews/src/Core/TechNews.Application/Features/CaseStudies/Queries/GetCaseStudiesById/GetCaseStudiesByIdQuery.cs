using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.CaseStudies.Queries.GetCaseStudiesById
{
    public class GetCaseStudiesByIdQuery : IRequest<Response<GetCaseStudiesByIdQueryDto>>
    {
        public int SectionMasterId { get; set; }
    }
}
