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

namespace TechNews.Application.Features.Podcast.Queries.GetAllpodcast
{
    public class GetAllPodcastQueryHandler : IRequestHandler<GetAllPodcastQuery, Response<List<GetAllPodcastDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IPodcastRepository _podcastRepository;
        private readonly ILogger<GetAllPodcastQueryHandler> _logger;

        public GetAllPodcastQueryHandler(IMapper mapper, IPodcastRepository podcastRepository, ILogger<GetAllPodcastQueryHandler> logger)
        {
            _mapper = mapper;
            _podcastRepository = podcastRepository;
            this._logger = logger;
        }

        public  async Task<Response<List<GetAllPodcastDto>>> Handle(GetAllPodcastQuery request, CancellationToken cancellationToken)
        {
            List<SectionMaster> podcast = await _podcastRepository.GetAllPodcast();
            var result = _mapper.Map<List<GetAllPodcastDto>>(podcast);
            return new Response<List<GetAllPodcastDto>>(result);
        }

        
    }
}
