using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IForgotPassword:IAsyncRepository<User>
    {
        Task<User> UserExists(string email);
        Task<User> ResetUserPassword(ResetPassword resetPassword);

        Task<User> ResetLoginPassword(ResetLoggedInPassword resetLoggedInPassword);
        Task<bool> OldPasswordDoesNotExists(OldPasswordExists oldPasswordExists);

    }
}
