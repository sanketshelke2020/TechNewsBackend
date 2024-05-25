using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Webinar.Command
{
    public class AddEnrollmentCommand : IRequest<Response<AddEnrollmentCommandDto>>
    {
        public int UserId { get; set; }
        public int WebinarId { get; set; }
    }
}
