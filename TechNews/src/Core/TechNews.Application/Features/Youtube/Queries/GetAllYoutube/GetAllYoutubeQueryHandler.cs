using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.Youtube.Queries.GetAllYoutube
{
    public class GetAllYoutubeQueryHandler : IRequestHandler<GetAllYoutubeQuery, Response<List<GetAllYoutubeQueryDto>>>
    {
        private readonly ILogger<GetAllYoutubeQueryHandler> _logger;
        private readonly  IYoutubeRepository _youtubeRepository;
        private readonly IMapper _mapper;
        public GetAllYoutubeQueryHandler(ILogger<GetAllYoutubeQueryHandler> logger, IYoutubeRepository youtubeRepository, IMapper mapper)
        {
            _logger = logger;
            _youtubeRepository = youtubeRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetAllYoutubeQueryDto>>> Handle(GetAllYoutubeQuery request, CancellationToken cancellationToken)
        {
            List<SectionMaster> sectionMasters = await _youtubeRepository.GetAllYoutube();
            var result = _mapper.Map<List<GetAllYoutubeQueryDto>>(sectionMasters);
            return new Response<List<GetAllYoutubeQueryDto>>(result);

        }
    }
}
