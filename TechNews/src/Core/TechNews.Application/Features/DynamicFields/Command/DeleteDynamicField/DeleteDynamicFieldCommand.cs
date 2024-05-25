using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.DynamicFields.Command.DeleteDynamicField
{
    public class DeleteDynamicFieldCommand: IRequest<Response<bool>>
    {
        public int DynamicFieldId { get; set; }
    }
}
