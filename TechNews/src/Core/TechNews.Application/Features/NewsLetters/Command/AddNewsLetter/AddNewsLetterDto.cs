using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.NewsLetters.Command.AddNewsLetter
{
    public class AddNewsLetterDto
    {
        public int NewsLetterId { get; set; }
        public string Email { get; set; }
    }
}
