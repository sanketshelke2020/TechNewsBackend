using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.GuestUsers.Commands.CreateGuestUser
{
    public class GuestUserDto
    {
        public int GuestUserId { get; set; }
        public string Email { get; set; }
    }
}
