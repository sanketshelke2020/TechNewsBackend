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

namespace TechNews.Application.Features.UserQueries.Query.GetUserQueryById
{
    public class GetUserQueryByIdHandler : IRequestHandler<GetUserQueryByIdQuery, Response<GetUserQueryByIdDto>>
    {
        private readonly IMapper _mapper;
        private readonly IQueriesrespository _queryRepository;
        private readonly ILogger<GetUserQueryByIdHandler> _logger;

        public GetUserQueryByIdHandler(IMapper mapper, IQueriesrespository queryRepository, ILogger<GetUserQueryByIdHandler> logger)
        {
            _mapper = mapper;
            _queryRepository = queryRepository;
            this._logger = logger;
        }
        public async Task<Response<GetUserQueryByIdDto>> Handle(GetUserQueryByIdQuery request, CancellationToken cancellationToken)
        {
            var query = await _queryRepository.GetUserQueryByid(request.QuerieId);
            var result = _mapper.Map<GetUserQueryByIdDto>(query);
            return new Response<GetUserQueryByIdDto>(result);
        }
    }
}
