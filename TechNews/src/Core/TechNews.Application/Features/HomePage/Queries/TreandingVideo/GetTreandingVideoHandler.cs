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

namespace TechNews.Application.Features.HomePage.Queries.TreandingVideo
{
    public class GetTreandingVideoHandler : IRequestHandler<GetTreandingVideoQuery,Response<List<GetTreandingVideoDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IHomePageRepository _homePageRepository;
        private readonly ILogger<GetTreandingVideoHandler> _logger;

        public GetTreandingVideoHandler(IMapper mapper, IHomePageRepository homePageRepository, ILogger<GetTreandingVideoHandler> logger)
        {
            _mapper = mapper;
            _homePageRepository = homePageRepository;
            this._logger = logger;
        }
        public async Task<Response<List<GetTreandingVideoDto>>> Handle(GetTreandingVideoQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("GetTreandingVideoHandler Initiated");

            List<SectionMaster> sectionMasters = await _homePageRepository.GettreandingVideo();
            var result = _mapper.Map<List<GetTreandingVideoDto>>(sectionMasters);

            _logger.LogInformation("GetTreandingVideoHandler Completed");
            return new Response<List<GetTreandingVideoDto>>(result);
        }
    }
}
