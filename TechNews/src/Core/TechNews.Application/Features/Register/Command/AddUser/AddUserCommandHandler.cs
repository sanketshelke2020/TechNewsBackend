using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts;
using TechNews.Application.Contracts.Infrastructure;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.Register.Command.AddUser
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, Response<AddUserCommandDto>>
    {
        private readonly ILogger<AddUserCommandHandler> _logger;
        private readonly IRegisterRepository  _registerRepository;
        private readonly IMapper _mapper;
        private readonly ISendMailService _mailService;

        public AddUserCommandHandler(ILogger<AddUserCommandHandler> logger, IRegisterRepository registerRepository, IMapper mapper, ISendMailService mailService)
        {
            _logger = logger;
            _registerRepository = registerRepository;
            _mapper = mapper;
            _mailService = mailService;
        }

        public async Task<Response<AddUserCommandDto>> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {

            _logger.LogInformation("AddUserCommandHandler Initiated");
            var user = _mapper.Map<User>(request);
            _registerRepository.CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            var response = await _registerRepository.AddAsync(user);
            if (response != null)
            {
                string subject = "Registration Successfully Done";
                string body = $"Respected {user.FirstName},<br> Welcome to TechNews your registration has been done and your Email id : {user.Email} and Password : {request.Password} has been set.";
                var result = _mailService.SendMail(user.Email, subject, body);
            }

            var userDto = _mapper.Map<AddUserCommandDto>(response);
            _logger.LogInformation("AddUserCommandHandler Completed");

            return new Response<AddUserCommandDto>(userDto, "Success");







            
        }
    }
}
