using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Exceptions;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterById
{
    public class GetSectionMasterByIdQueryHandler : IRequestHandler<GetSectionMasterByIdQuery, Response<GetSectionMasterByIdDto>>
    {
        private readonly ISectionMasterRepository _sectionMasterRepository;
        private readonly IMapper _mapper;

        public GetSectionMasterByIdQueryHandler(ISectionMasterRepository sectionMasterRepository,IMapper mapper)
        {
            this._sectionMasterRepository = sectionMasterRepository;
            this._mapper = mapper;
        }
        public async Task<Response<GetSectionMasterByIdDto>> Handle(GetSectionMasterByIdQuery request, CancellationToken cancellationToken)
        {
            SectionMaster sectionObj = await _sectionMasterRepository.GetSectionByIdAsync(request.SectionMasterId);
            if (sectionObj == null)
            {
                throw new NotFoundException(nameof(SectionMaster), request.SectionMasterId);
            }
            var data = _mapper.Map<GetSectionMasterByIdDto>(sectionObj);
            return new Response<GetSectionMasterByIdDto>(data);
        }
    }
}
