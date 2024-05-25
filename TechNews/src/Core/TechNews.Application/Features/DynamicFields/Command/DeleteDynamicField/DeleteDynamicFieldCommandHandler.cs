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

namespace TechNews.Application.Features.DynamicFields.Command.DeleteDynamicField
{
    public class DeleteDynamicFieldCommandHandler : IRequestHandler<DeleteDynamicFieldCommand, Response<bool>>
    {
        private readonly ILogger<DeleteDynamicFieldCommandHandler> _logger;
        private readonly IDynamicFieldRepository _dynamicFieldRepository;
        private readonly IMapper _mapper;
        public DeleteDynamicFieldCommandHandler(ILogger<DeleteDynamicFieldCommandHandler> logger, IDynamicFieldRepository dynamicFieldRepository, IMapper mapper)
        {
            _logger = logger;
            _dynamicFieldRepository = dynamicFieldRepository;
            _mapper = mapper;
        }

        public async Task<Response<bool>> Handle(DeleteDynamicFieldCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("DeleteDynamicFieldCommandDto Initiated");
            var dynamicField = _mapper.Map<DynamicField>(request);
            await _dynamicFieldRepository.DeleteAsync(dynamicField);
            _logger.LogInformation("DeleteDynamicFieldCommandDto Completed");
            return new Response<bool>(true, "Success");
        }
    }
}
