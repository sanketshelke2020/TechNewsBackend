using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Magazines.Query.GetAllMagazine
{
    public class GetAllMagazineQuery:IRequest<Response<List<GetAllMagazineDto>>>
    {
    }
}
