using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.Articles.Queries.GetAllArticle
{
    public class GetAllArticleQueryHandler : IRequestHandler<GetAllArticleQuery, Response<List<GetAllArticleQueryDto>>>
    {
        private readonly ILogger<GetAllArticleQueryHandler> _logger;
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;
        public GetAllArticleQueryHandler(ILogger<GetAllArticleQueryHandler> logger, IArticleRepository articleRepository, IMapper mapper)
        {
            _logger = logger;
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetAllArticleQueryDto>>> Handle(GetAllArticleQuery request, CancellationToken cancellationToken)
        {
            List<SectionMaster> sectionMasters = await _articleRepository.GetAllArticle();
            var result = _mapper.Map<List<GetAllArticleQueryDto>>(sectionMasters);
            return new Response<List<GetAllArticleQueryDto>>(result);
        }
    }
}
