using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Webinar.Queries.GetAllWebinar;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.Webinar.Queries.GetAllEnrolledUser
{
    public class GetAllEnrolledUserQueryHandler : IRequestHandler<GetAllEnrolledUserQuery, Response<List<GetAllEnrolledUserQueryDto>>>
    {
        private readonly ILogger<GetAllEnrolledUserQueryHandler> _logger;
        private readonly IEnrollmentRepository _enrollmentRepository;
        private readonly IMapper _mapper;
        public async Task<Response<List<GetAllEnrolledUserQueryDto>>> Handle(GetAllEnrolledUserQuery request, CancellationToken cancellationToken)
        {
            List<Enrollment> sectionMasters = await _enrollmentRepository.GetAllEnrolledUser(request.WebinarId);
            var result = _mapper.Map<List<GetAllEnrolledUserQueryDto>>(sectionMasters);
            return new Response<List<GetAllEnrolledUserQueryDto>>(result);
        }
    }
}
