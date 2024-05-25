using TechNews.Application.Models.Mail;
using System.Threading.Tasks;

namespace TechNews.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}
