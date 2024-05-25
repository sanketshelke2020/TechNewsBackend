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

namespace TechNews.Application.Features.Magazines.Query.GetMagazineById
{
    public class GetMagazineByIdQueryHandler:IRequestHandler<GetMgazineByIdQuery,Response<GetMagazineByIdDto>>
    {
        private readonly IMapper _mapper;
        private readonly IMagazineRepository _magazinePageRepository;
        private readonly ILogger<GetMagazineByIdQueryHandler> _logger;

        public GetMagazineByIdQueryHandler(IMapper mapper, IMagazineRepository magazinePageRepository, ILogger<GetMagazineByIdQueryHandler> logger)
        {
            _mapper = mapper;
            _magazinePageRepository = magazinePageRepository;
            this._logger = logger;
        }

        public async Task<Response<GetMagazineByIdDto>> Handle(GetMgazineByIdQuery request, CancellationToken cancellationToken)
        {
            var magazine =  await _magazinePageRepository.GetMagazineById(request.SectionMasterId);
            var result = _mapper.Map<GetMagazineByIdDto>(magazine);
            return new Response<GetMagazineByIdDto>(result);
        }
    }
}
