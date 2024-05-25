using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Webinar.Queries.GetAllWebinar;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Webinar.Queries.GetAllEnrolledUser
{
    public class GetAllEnrolledUserQuery : IRequest<Response<List<GetAllEnrolledUserQueryDto>>>
    {
        public int WebinarId { get; set; }
    }
}
