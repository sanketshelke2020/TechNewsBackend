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

namespace TechNews.Application.Features.Articles.Queries.GetArticleById
{
    public class GetArticleByIdQueryHandler : IRequestHandler<GetArticleByIdQuery, Response<GetArticleByIdQueryDto>>
    {
        private readonly ILogger<GetArticleByIdQueryHandler> _logger;
        private readonly IArticleRepository _articleRepository;
        private readonly IMapper _mapper;
        public GetArticleByIdQueryHandler(ILogger<GetArticleByIdQueryHandler> logger, IArticleRepository articleRepository, IMapper mapper)
        {
            _logger = logger;
            _articleRepository = articleRepository;
            _mapper = mapper;
        }

        public async Task<Response<GetArticleByIdQueryDto>> Handle(GetArticleByIdQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(" GetArticleByIdQueryHandler Initaiated");
            var article = await _articleRepository.GetArticleById(request.SectionMasterId);
            var result = _mapper.Map<GetArticleByIdQueryDto>(article);
            return new Response<GetArticleByIdQueryDto>(result);


        }
    }
}
