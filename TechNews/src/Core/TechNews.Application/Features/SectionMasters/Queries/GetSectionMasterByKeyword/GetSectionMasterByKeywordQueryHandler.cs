using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByKeyword
{
    public class GetSectionMasterByKeywordQueryHandler : IRequestHandler<GetSectionMasterByKeywordQuery, Response<List<GetSectionMasterByKeywordDto>>>
    {
        private readonly IMapper _mapper;
        private readonly ISectionMasterRepository _sectionMasterRepository;

        public GetSectionMasterByKeywordQueryHandler(IMapper mapper, ISectionMasterRepository sectionMasterRepository)
        {
            this._mapper = mapper;
            this._sectionMasterRepository = sectionMasterRepository;
        }
        public async Task<Response<List<GetSectionMasterByKeywordDto>>> Handle(GetSectionMasterByKeywordQuery request, CancellationToken cancellationToken)
        {
            var result = await _sectionMasterRepository.ListAllAsync();
            var data = result.Where(x => x.KeyWords.Contains((request.SearchKeyword)) && x.IsDeleted == false);
            var response = new Response<List<GetSectionMasterByKeywordDto>>(_mapper.Map<List<GetSectionMasterByKeywordDto>>(data));
            return response;
        }
    }
}
