using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByKeyword;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByDate
{
    public class GetSectionMasterByDateQueryHandler : IRequestHandler<GetSectionMasterByDateQuery, Response<List<GetSectionMasterByDateDto>>>
    {
        private readonly IMapper _mapper;
        private readonly ISectionMasterRepository _sectionMasterRepository;

        public GetSectionMasterByDateQueryHandler(IMapper mapper, ISectionMasterRepository sectionMasterRepository)
        {
            this._mapper = mapper;
            this._sectionMasterRepository = sectionMasterRepository;
        }
        public async Task<Response<List<GetSectionMasterByDateDto>>> Handle(GetSectionMasterByDateQuery request, CancellationToken cancellationToken)
        {
            var result = await _sectionMasterRepository.ListAllAsync();
            var data = result.Where(x => x.CreatedDate > DateTime.Now.AddDays(-1) && x.IsDeleted == false);
            var response = new Response<List<GetSectionMasterByDateDto>>(_mapper.Map<List<GetSectionMasterByDateDto>>(data));
            return response;
        }
    }
}
