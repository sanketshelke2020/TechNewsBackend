using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.UserQueries.Query.GetUserQueryById
{
    public class GetUserQueryByIdQuery :IRequest<Response<GetUserQueryByIdDto>>
    {
        public int QuerieId { get; set; }
    }
}
