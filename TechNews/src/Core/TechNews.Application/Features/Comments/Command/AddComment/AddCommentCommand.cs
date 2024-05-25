using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Comments.Command.AddComment
{
    public class AddCommentCommand:IRequest<Response<AddCommentCommandDto>>
    { 
        public string CommentDescription { get; set; }
        public string Email { get; set; }

        public int SectionMasterId { get; set; }
    }
}
