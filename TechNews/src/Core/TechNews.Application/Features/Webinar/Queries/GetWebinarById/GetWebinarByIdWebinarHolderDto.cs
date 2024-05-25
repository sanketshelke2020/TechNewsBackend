using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Webinar.Queries.GetWebinarById
{
    public class GetWebinarByIdWebinarHolderDto
    {
        public int WebinarHolderId { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }

        public int WebinarId { get; set; }
    }
}
