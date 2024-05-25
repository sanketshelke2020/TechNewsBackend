using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.DynamicFields.Queries.GetAllDynamicField
{
    public class GetAllDynamicFieldQueryHandler : IRequestHandler<GetAllDynamicFieldQuery, Response<List<GetAllDynamicFieldQueryDto>>>
    {
        private readonly ILogger<GetAllDynamicFieldQueryHandler> _logger;
        private readonly IDynamicFieldRepository _dynamicFieldRepository;
        private readonly IMapper _mapper;
        public GetAllDynamicFieldQueryHandler(ILogger<GetAllDynamicFieldQueryHandler> logger, IDynamicFieldRepository dynamicFieldRepository, IMapper mapper)
        {
            _logger = logger;
            _dynamicFieldRepository = dynamicFieldRepository;
            _mapper = mapper;
        }

        public async Task<Response<List<GetAllDynamicFieldQueryDto>>> Handle(GetAllDynamicFieldQuery request, CancellationToken cancellationToken)
        {
            List<DynamicField> dynamicFields = await _dynamicFieldRepository.GetAllDynamicField();
            var result = _mapper.Map<List<GetAllDynamicFieldQueryDto>>(dynamicFields);
            return new Response<List<GetAllDynamicFieldQueryDto>>(result);
        }
    }
}
