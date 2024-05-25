using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Register.Command.AddUser;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;
using TechNews.Infrastructure.EncryptDecrypt;

namespace TechNews.Application.Features.DynamicFields.Command.AddDynamicField
{
    public class AddDynamicFieldCommandHandler : IRequestHandler<AddDynamicFieldCommand, Response<AddDynamicFieldCommandDto>>
    {
        private readonly ILogger<AddDynamicFieldCommandHandler> _logger;
        private readonly IDynamicFieldRepository _dynamicFieldRepository;
        private readonly IMapper _mapper;
        public AddDynamicFieldCommandHandler(ILogger<AddDynamicFieldCommandHandler> logger, IDynamicFieldRepository dynamicFieldRepository, IMapper mapper)
        {
            _logger = logger;
            _dynamicFieldRepository = dynamicFieldRepository;
            _mapper = mapper;
        }

        public async Task<Response<AddDynamicFieldCommandDto>> Handle(AddDynamicFieldCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("AddDynamicFieldCommandHandler Initiated");
            var dynamicField = _mapper.Map<DynamicField>(request);
            var response = await _dynamicFieldRepository.AddAsync(dynamicField);
            var dynamicFieldDto = _mapper.Map<AddDynamicFieldCommandDto>(response);
            
            _logger.LogInformation("AddDynamicFieldCommandHandler Completed");
            return new Response<AddDynamicFieldCommandDto>(dynamicFieldDto, "Success");

        }
    }
}
