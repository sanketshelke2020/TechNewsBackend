using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Register.Query.GetUserById
{
    public class GetUserByIdQuery:IRequest<Response<GetUserByIdDto>>
    {
        public int UserId { get; set; }
    }
}
