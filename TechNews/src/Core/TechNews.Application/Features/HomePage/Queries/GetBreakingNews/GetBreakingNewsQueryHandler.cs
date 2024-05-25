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

namespace TechNews.Application.Features.HomePage.Queries.GetBreakingNews
{
    public class GetBreakingNewsQueryHandler : IRequestHandler<GetBreakingNewsQuery, Response<List<GetBreakingNewsDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IHomePageRepository _homePageRepository;
        private readonly ILogger<GetBreakingNewsQueryHandler> _logger;

        public GetBreakingNewsQueryHandler(IMapper mapper, IHomePageRepository homePageRepository, ILogger<GetBreakingNewsQueryHandler> logger)
        {
            _mapper = mapper;
            _homePageRepository = homePageRepository;
            this._logger = logger;
        }

        public async Task<Response<List<GetBreakingNewsDto>>> Handle(GetBreakingNewsQuery request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("Inside GetBreaking News");
            var breakingNews = _homePageRepository.GetBreakingNews();
            var result = _mapper.Map<List<GetBreakingNewsDto>>(breakingNews);
            return new Response<List<GetBreakingNewsDto>>(result);
        }
    }
}
