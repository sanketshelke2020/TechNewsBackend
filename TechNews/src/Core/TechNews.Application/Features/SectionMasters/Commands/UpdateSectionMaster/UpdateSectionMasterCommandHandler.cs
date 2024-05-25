using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Responses;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.SectionMasters.Commands.UpdateSectionMaster
{
    public class UpdateSectionMasterCommandHandler : IRequestHandler<UpdateSectionMasterCommand, Response<bool>>
    {
        private readonly ISectionMasterRepository _sectionMasterRepository;
        private readonly IMapper _mapper;
        private readonly IStoredFileRepository _storedFileRepository;

        public UpdateSectionMasterCommandHandler(ISectionMasterRepository section,IMapper mapper,IStoredFileRepository storedFileRepository)
        {
            this._sectionMasterRepository = section;
            this._mapper = mapper;
            this._storedFileRepository = storedFileRepository;
        }
        public async Task<Response<bool>> Handle(UpdateSectionMasterCommand request, CancellationToken cancellationToken)
        {
            if (request.YoutubeVideoLink != null && request.StoredFileId != 0)
            {
                _storedFileRepository.RemoveStoredFileById(request.StoredFileId);
            }
            SectionMaster section = _mapper.Map<SectionMaster>(request);
            var result = _sectionMasterRepository.UpdateSection(section);
            return new Response<bool>(result);
        }
    }
}
