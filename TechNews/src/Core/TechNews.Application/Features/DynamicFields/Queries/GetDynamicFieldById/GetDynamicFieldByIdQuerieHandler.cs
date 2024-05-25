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
using TechNews.Application.Features.DynamicFields.Command.DeleteDynamicField;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.DynamicFields.Queries.GetDynamicFieldById
{
    public class GetDynamicFieldByIdQuerieHandler : IRequestHandler<GetDynamicFieldByIdQuerie, Response<GetDynamicFieldByIdQuerieDto>>
    {
        private readonly ILogger<GetDynamicFieldByIdQuerieHandler> _logger;
        private readonly IDynamicFieldRepository _dynamicFieldRepository;
        private readonly IMapper _mapper;
        public GetDynamicFieldByIdQuerieHandler(ILogger<GetDynamicFieldByIdQuerieHandler> logger, IDynamicFieldRepository dynamicFieldRepository, IMapper mapper)
        {
            _logger = logger;
            _dynamicFieldRepository = dynamicFieldRepository;
            _mapper = mapper;
        }

        public async Task<Response<GetDynamicFieldByIdQuerieDto>> Handle(GetDynamicFieldByIdQuerie request, CancellationToken cancellationToken)
        {
            _logger.LogInformation(" GetDynamicFieldByIdQuerieHandler Initaiated");
            var dynamicFields = await _dynamicFieldRepository.GetDynamicFieldById(request.DynamicFieldId);
            var result = _mapper.Map<GetDynamicFieldByIdQuerieDto>(dynamicFields);
            return new Response<GetDynamicFieldByIdQuerieDto>(result);
        }
    }
}
