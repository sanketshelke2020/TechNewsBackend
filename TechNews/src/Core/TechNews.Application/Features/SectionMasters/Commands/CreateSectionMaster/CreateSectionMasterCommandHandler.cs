using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.SectionMasters.Commands.CreateSectionMaster
{
    public class CreateSectionMasterCommandHandler : IRequestHandler<CreateSectionMasterCommand, Response<CreateSectionMasterDto>>
    {
        private readonly IMapper _mapper;
        private readonly ISectionMasterRepository _sectionMasterRepository;

        public CreateSectionMasterCommandHandler(IMapper mapper, ISectionMasterRepository sectionMasterRepository)
        {
            _mapper = mapper;
            _sectionMasterRepository = sectionMasterRepository;
        }
        public async Task<Response<CreateSectionMasterDto>> Handle(CreateSectionMasterCommand request, CancellationToken cancellationToken)
        {
            var result = await _sectionMasterRepository.AddAsync(_mapper.Map<SectionMaster>(request));
            return new Response<CreateSectionMasterDto>(_mapper.Map<CreateSectionMasterDto>(result));
        }
    }
}
