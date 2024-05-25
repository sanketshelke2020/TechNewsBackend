using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.DynamicFields.Query.GetDynamicFieldByCategory;

namespace TechNews.Application.Features.DynamicFields.Query.GetDynamicFieldByCategoryQuery
{
    public class GetDynamicFieldByCategoryHandler : IRequestHandler<GetDynamicFieldByCategoryQueris, List<GetDynamicFieldByCategoryDto>>
    {
        private readonly ILogger<GetDynamicFieldByCategoryHandler> _logger;
        private readonly IDynamicFieldRepository _dynamicFieldRepository;
        private readonly IMapper _mapper;
        public GetDynamicFieldByCategoryHandler(ILogger<GetDynamicFieldByCategoryHandler> logger, IDynamicFieldRepository dynamicFieldRepository, IMapper mapper)
        {
            _logger = logger;
            _dynamicFieldRepository = dynamicFieldRepository;
            _mapper = mapper;
        }
        public async Task<List<GetDynamicFieldByCategoryDto>> Handle(GetDynamicFieldByCategoryQueris request, CancellationToken cancellationToken)
        {
            var result = await _dynamicFieldRepository.GetDynamicFieldBycategory(request.CategoryType);
            List<GetDynamicFieldByCategoryDto> response = _mapper.Map<List<GetDynamicFieldByCategoryDto>>(result);
            return new List<GetDynamicFieldByCategoryDto>(response);
        }
    }
}
