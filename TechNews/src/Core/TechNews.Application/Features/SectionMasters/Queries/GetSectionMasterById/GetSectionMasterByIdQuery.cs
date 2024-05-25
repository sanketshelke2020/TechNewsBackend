using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterById
{
    public class GetSectionMasterByIdQuery : IRequest<Response<GetSectionMasterByIdDto>>
    {
        public int SectionMasterId { get; set; }
    }
}
