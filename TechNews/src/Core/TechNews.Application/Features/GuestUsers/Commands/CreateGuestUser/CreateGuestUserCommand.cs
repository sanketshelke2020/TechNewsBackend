using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.GuestUsers.Commands.CreateGuestUser
{
    public class CreateGuestUserCommand : IRequest<Response<GuestUserDto>>
    {
        public string Email { get; set; }
    }
}
