using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Youtube.Queries.GetYoutubeById
{
    public class GetYoutubeByIdQueryHandler : IRequestHandler<GetYoutubeByIdQuery, Response<GetYoutubeByIdQueryDto>>
    {
        private readonly ILogger<GetYoutubeByIdQueryHandler> _logger;
        private readonly IYoutubeRepository _youtubeRepository;
        private readonly IMapper _mapper;
        public GetYoutubeByIdQueryHandler(ILogger<GetYoutubeByIdQueryHandler> logger, IYoutubeRepository youtubeRepository, IMapper mapper)
        {
            _logger = logger;
            _youtubeRepository = youtubeRepository;
            _mapper = mapper;
        }

        public async Task<Response<GetYoutubeByIdQueryDto>> Handle(GetYoutubeByIdQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(" GetYoutubeByIdQueryHandler Initaiated");
            var youtube = await _youtubeRepository.GetYoutubeById(request.SectionMasterId);
            var result = _mapper.Map<GetYoutubeByIdQueryDto>(youtube);
            return new Response<GetYoutubeByIdQueryDto>(result);

        }
    }
}
