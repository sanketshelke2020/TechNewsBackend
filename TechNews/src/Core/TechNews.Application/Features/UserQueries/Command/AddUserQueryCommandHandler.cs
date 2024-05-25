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

namespace TechNews.Application.Features.UserQueries.Command
{
    public class AddUserQueryCommandHandler : IRequestHandler<AddUserQueryCommand, Response<AddUserQueryCommandDto>>
    {
        private readonly ILogger<AddUserQueryCommandHandler> _logger;
        private readonly  IQueriesrespository _queriesrespository;
        private readonly IMapper _mapper;
        public AddUserQueryCommandHandler(ILogger<AddUserQueryCommandHandler> logger, IQueriesrespository queriesrespository, IMapper mapper)
        {
            _logger = logger;
            _queriesrespository = queriesrespository;
            _mapper = mapper;
        }

        public async Task<Response<AddUserQueryCommandDto>> Handle(AddUserQueryCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("AddUserQueryCommandHandler Initiated");
            var querie = _mapper.Map<Querie>(request);
            var response = await _queriesrespository.AddAsync(querie);
            var querieDto = _mapper.Map<AddUserQueryCommandDto>(response);
            _logger.LogInformation("AddUserQueryCommandHandler Completed");
            return new Response<AddUserQueryCommandDto>(querieDto, "Success");
        }
    }
}
