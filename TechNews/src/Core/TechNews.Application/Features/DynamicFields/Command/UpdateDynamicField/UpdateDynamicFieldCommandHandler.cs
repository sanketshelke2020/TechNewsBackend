using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.DynamicFields.Command.AddDynamicField;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.DynamicFields.Command.UpdateDynamicField
{
    public class UpdateDynamicFieldCommandHandler : IRequestHandler<UpdateDynamicFieldCommand, Response<UpdateDynamicFieldCommandDto>>
    {
        private readonly ILogger<UpdateDynamicFieldCommandHandler> _logger;
        private readonly IDynamicFieldRepository _dynamicFieldRepository;
        private readonly IMapper _mapper;
        public UpdateDynamicFieldCommandHandler(ILogger<UpdateDynamicFieldCommandHandler> logger, IDynamicFieldRepository dynamicFieldRepository, IMapper mapper)
        {
            _logger = logger;
            _dynamicFieldRepository = dynamicFieldRepository;
            _mapper = mapper;
        }

        public async Task<Response<UpdateDynamicFieldCommandDto>> Handle(UpdateDynamicFieldCommand request, CancellationToken cancellationToken)
        {

            _logger.LogInformation("UpdateDynamicFieldCommandHandler Initiated");
            var dynamicField = _mapper.Map<DynamicField>(request);
            await _dynamicFieldRepository.UpdateAsync(dynamicField);

            var dynamicFieldUpdated = _mapper.Map<DynamicField>(dynamicField);
            var dynamicFieldDto = _mapper.Map<UpdateDynamicFieldCommandDto>(dynamicFieldUpdated);

            _logger.LogInformation("UpdateDynamicFieldCommandHandler Completed");
            return new Response<UpdateDynamicFieldCommandDto>(dynamicFieldDto, "Success");
        }
    }
}
