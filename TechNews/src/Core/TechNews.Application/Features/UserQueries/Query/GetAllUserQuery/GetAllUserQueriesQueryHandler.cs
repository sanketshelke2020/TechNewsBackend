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

namespace TechNews.Application.Features.UserQueries.Query.GetAllUserQuery
{
    public class GetAllUserQueriesQueryHandler : IRequestHandler<GetAllUserQueriesQuery,Response<List<GetAllUserQueriesDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IQueriesrespository _queryRepository;  
        private readonly ILogger<GetAllUserQueriesQueryHandler> _logger;

        public GetAllUserQueriesQueryHandler(IMapper mapper, IQueriesrespository queryRepository, ILogger<GetAllUserQueriesQueryHandler> logger)
        {
            _mapper = mapper;
            _queryRepository = queryRepository;
            this._logger = logger;
        }
        public async Task<Response<List<GetAllUserQueriesDto>>> Handle(GetAllUserQueriesQuery request, CancellationToken cancellationToken)
        {
            var queries = await _queryRepository.ListAllAsync();
            List<GetAllUserQueriesDto> result = _mapper.Map<List<GetAllUserQueriesDto>>(queries);
            return new Response<List<GetAllUserQueriesDto>>(result);
        }
    }
}
