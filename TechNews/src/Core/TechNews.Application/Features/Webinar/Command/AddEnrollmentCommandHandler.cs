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

namespace TechNews.Application.Features.Webinar.Command
{
    public class AddEnrollmentCommandHandler : IRequestHandler<AddEnrollmentCommand, Response<AddEnrollmentCommandDto>>
    {
        private readonly IWebinarRepository _webinarRepository;
        private readonly ILogger<AddEnrollmentCommandHandler> _logger;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IMapper _mapper;
        public AddEnrollmentCommandHandler(IWebinarRepository webinarRepository,ILogger<AddEnrollmentCommandHandler> logger, IEnrollmentRepository enrollmentRepository, IMapper mapper)
        {
            _webinarRepository = webinarRepository;
            _logger = logger;
            _enrollmentRepository = enrollmentRepository;
            
            _mapper = mapper;
        }

        public async Task<Response<AddEnrollmentCommandDto>> Handle(AddEnrollmentCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("AddEnrollmentCommandHandler Initiated");
            var user = _mapper.Map<Enrollment>(request);
            //var webinar = _webinarRepository.GetWebinarById(request.WebinarId).Result;
            //if (webinar.re == null)
            Enrollment enrollment = await _enrollmentRepository.GetEnrollmentByUserAndWebinarId(request.UserId, request.WebinarId);
            if (enrollment is null)
            {
                var response = await _enrollmentRepository.AddAsync(user);
                var userDto = _mapper.Map<AddEnrollmentCommandDto>(response);
                _logger.LogInformation("AddEnrollmentCommandHandler Completed");
                return new Response<AddEnrollmentCommandDto>(userDto, "Enrollment done for this webinar");
            }
            return new Response<AddEnrollmentCommandDto>(_mapper.Map<AddEnrollmentCommandDto>(enrollment), "Already Enrolled for this webinar");
        }
    }
}
