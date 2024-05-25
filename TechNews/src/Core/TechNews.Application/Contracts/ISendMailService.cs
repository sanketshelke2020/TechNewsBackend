using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Contracts
{
    public interface ISendMailService
    {
        public bool SendMail(string email , string subject, string body);
    }
}
