using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.EventSchedule.Queries.GetEventSheduleById
{
    public class GetEventSheduleByIdCommentDto
    {
        public int CommentId { get; set; }

        public string CommentDescription { get; set; }
        public string Email { get; set; }

    }
}
