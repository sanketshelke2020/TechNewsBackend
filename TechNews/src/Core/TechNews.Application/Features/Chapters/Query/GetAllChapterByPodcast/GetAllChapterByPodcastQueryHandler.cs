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

namespace TechNews.Application.Features.Chapters.Query.GetAllChapterByPodcast
{
    public class GetAllChapterByPodcastQueryHandler:IRequestHandler<GetAllChapterByPodcastQuery,Response<List<GetAllChapterByPodcastDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IChapterRepository _chaptertRepository;
        private readonly ILogger<GetAllChapterByPodcastQueryHandler> _logger;

        public GetAllChapterByPodcastQueryHandler(IMapper mapper, IChapterRepository chapterRepository, ILogger<GetAllChapterByPodcastQueryHandler> logger)
        {
            _mapper = mapper;
            _chaptertRepository = chapterRepository;
            this._logger = logger;
        }

        public async Task<Response<List<GetAllChapterByPodcastDto>>> Handle(GetAllChapterByPodcastQuery request, CancellationToken cancellationToken)
        {
            var chapters =  await _chaptertRepository.GetAllChapterByPodcastId(request.PodcastId);
            var result = _mapper.Map<List<GetAllChapterByPodcastDto>>(chapters);
            return new Response<List<GetAllChapterByPodcastDto>>(result);


        }
    }
}
