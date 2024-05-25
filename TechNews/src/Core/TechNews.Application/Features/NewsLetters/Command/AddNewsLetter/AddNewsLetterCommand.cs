using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.NewsLetters.Command.AddNewsLetter
{
    public class AddNewsLetterCommand:IRequest<Response<AddNewsLetterDto>>
    {
        public string Email { get; set; }
    }
}
