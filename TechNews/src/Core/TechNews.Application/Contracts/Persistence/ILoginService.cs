using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Models.Authentication;

namespace TechNews.Application.Contracts.Persistence
{
    public interface ILoginService
    {
        public Task<AuthenticationResponse> Login(string email, string password);
    }
}
