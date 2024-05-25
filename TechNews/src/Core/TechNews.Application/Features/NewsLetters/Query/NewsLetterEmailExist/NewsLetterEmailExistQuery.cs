
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.NewsLetters.Query.NewsLetterEmailExist
{
    public class NewsLetterEmailExistQuery:IRequest<Response<bool>>
    {
        public string Email { get; set; }
    }
}
