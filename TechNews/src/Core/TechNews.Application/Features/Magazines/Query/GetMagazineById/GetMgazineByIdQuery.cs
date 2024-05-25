using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Magazines.Query.GetMagazineById
{
    public class GetMgazineByIdQuery:IRequest<Response<GetMagazineByIdDto>>
    {
        public int SectionMasterId { get; set; }
    }
}
