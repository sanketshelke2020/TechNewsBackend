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

namespace TechNews.Application.Features.Podcast.Queries.GetChapterById
{
    public class GetChapterByIdQueryHandler:IRequestHandler<GetChapterByIdQuery,Response<GetChapterByIdDto>>
    {
        private readonly IMapper _mapper;
        private readonly IPodcastRepository _podcastRepository;
        private readonly ILogger<GetChapterByIdQueryHandler> _logger;

        public GetChapterByIdQueryHandler(IMapper mapper, IPodcastRepository podcastRepository, ILogger<GetChapterByIdQueryHandler> logger)
        {
            _mapper = mapper;
            _podcastRepository = podcastRepository;
            this._logger = logger;
        }

        public async Task<Response<GetChapterByIdDto>> Handle(GetChapterByIdQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("GetChapterByIdHandler Inititated");
            var chapter =  await _podcastRepository.GetChapterById(request.ChapterId);
            var result = _mapper.Map<GetChapterByIdDto>(chapter);
            _logger.LogInformation("GetChapterByIdHandler Completed");
            return new Response<GetChapterByIdDto>(result);

        }
    }
}
