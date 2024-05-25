using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByCategory
{
    public class GetSectionMasterByCategoryQueryHandler : IRequestHandler<GetSectionMasterByCategoryQuery, Response<List<GetSectionMasterByCategoryQueryDto>>>
    {
        private readonly IMapper _mapper;
        private readonly ISectionMasterRepository _sectionMasterRepository;

        public GetSectionMasterByCategoryQueryHandler(IMapper mapper, ISectionMasterRepository sectionMasterRepository)
        {
            this._mapper = mapper;
            this._sectionMasterRepository = sectionMasterRepository;
        }
        public async Task<Response<List<GetSectionMasterByCategoryQueryDto>>> Handle(GetSectionMasterByCategoryQuery request, CancellationToken cancellationToken)
        {
            var sectionmaster = await _sectionMasterRepository.GetSectionMasterByCategory(request.CategoryType);
            var result = _mapper.Map<List<GetSectionMasterByCategoryQueryDto>>(sectionmaster);
            return new Response<List<GetSectionMasterByCategoryQueryDto>>(result);
        }
    }
}
