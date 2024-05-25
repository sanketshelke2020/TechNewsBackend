using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Exceptions;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.GuestUsers.Commands.CreateGuestUser
{
    public class CreateGuestUserCommandHandler : IRequestHandler<CreateGuestUserCommand, Response<GuestUserDto>>
    {
        private readonly IMapper _mapper;
        private readonly IGuestUserRepository _guestUserRepository;
        private readonly ILogger<CreateGuestUserCommandHandler> _logger;

        public CreateGuestUserCommandHandler(IMapper mapper, IGuestUserRepository guestUserRepository,ILogger<CreateGuestUserCommandHandler> logger)
        {
            _mapper = mapper;
            _guestUserRepository = guestUserRepository;
            this._logger = logger;
        }
        public async Task<Response<GuestUserDto>> Handle(CreateGuestUserCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("CreateGuestUserCommandHandler Initiated");
            var userExist = await _guestUserRepository.GetByEmailAsync(request.Email);
            if (userExist == null)
            {
                var user = _mapper.Map<GuestUser>(request);
                var result = await _guestUserRepository.AddAsync(user);
                var response = new Response<GuestUserDto>(_mapper.Map<GuestUserDto>(result));
                _logger.LogInformation("CreateGuestUserCommandHandler Completed");
                return response;
            }
            return new Response<GuestUserDto>(_mapper.Map<GuestUserDto>(userExist));

        }
    }
}
