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

namespace TechNews.Application.Features.Register.Command.UpdateUser
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, Response<UpdateuserCommandDto>>
    {
        private readonly ILogger<UpdateUserCommandHandler> _logger;
        private readonly IRegisterRepository _registerRepository;
        private readonly IMapper _mapper;


        public UpdateUserCommandHandler(ILogger<UpdateUserCommandHandler> logger, IRegisterRepository registerRepository, IMapper mapper)
        {
            _logger = logger;
            _registerRepository = registerRepository;
            _mapper = mapper;

        }

        public  async Task<Response<UpdateuserCommandDto>> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);
             await _registerRepository.UpdateAsync(user);
            var response =  _mapper.Map<UpdateuserCommandDto>(user);
            return new Response<UpdateuserCommandDto>(response);
        }
    }
}
