using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.DynamicFields.Queries.GetDynamicFieldById
{
    public class GetDynamicFieldByIdQuerie : IRequest<Response<GetDynamicFieldByIdQuerieDto>>
    {
        public int DynamicFieldId { get; set; }

    }
}
