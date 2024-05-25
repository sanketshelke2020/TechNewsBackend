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

namespace TechNews.Application.Features.Podcast.Queries.GetPodcastById
{
    public class GetPodcastByIdQueryHandler : IRequestHandler<GetPodcastByIdQuery, Response<GetPodcastByIdDto>>
    {
        private readonly IMapper _mapper;
        private readonly IPodcastRepository _podcastRepository;
        private readonly ILogger<GetPodcastByIdQueryHandler> _logger;

        public GetPodcastByIdQueryHandler(IMapper mapper, IPodcastRepository podcastRepository, ILogger<GetPodcastByIdQueryHandler> logger)
        {
            _mapper = mapper;
            _podcastRepository = podcastRepository;
            this._logger = logger;
        }
        public  async Task<Response<GetPodcastByIdDto>> Handle(GetPodcastByIdQuery request, CancellationToken cancellationToken)
        {
            var podcast =  await _podcastRepository.GetPodcastById(request.SectionMasterId);
            if (podcast != null)
            {
                var result = _mapper.Map<GetPodcastByIdDto>(podcast);
                return new Response<GetPodcastByIdDto>(result);
            }
            else
            {
                throw new Exception("Podcast by this id is not exit.");
            }
            
        }
    }
}
