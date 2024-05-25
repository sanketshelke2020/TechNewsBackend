using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Webinar.Queries.GetAllEnrolledUser
{
    public class GetAllEnrolledUserQueryDto
    {
        public int UserId { get; set; }
        public int WebinarId { get; set; }
    }
}
