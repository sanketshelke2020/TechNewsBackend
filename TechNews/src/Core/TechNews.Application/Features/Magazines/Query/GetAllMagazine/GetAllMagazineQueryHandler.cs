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

namespace TechNews.Application.Features.Magazines.Query.GetAllMagazine
{
    public class GetAllMagazineQueryHandler : IRequestHandler<GetAllMagazineQuery, Response<List<GetAllMagazineDto>>>
    {
        private readonly IMapper _mapper;
        private readonly IMagazineRepository _magazinePageRepository;
        private readonly ILogger<GetAllMagazineQueryHandler> _logger;

        public GetAllMagazineQueryHandler(IMapper mapper, IMagazineRepository magazinePageRepository, ILogger<GetAllMagazineQueryHandler> logger)
        {
            _mapper = mapper;
            _magazinePageRepository = magazinePageRepository;
            this._logger = logger;
        }

        public async  Task<Response<List<GetAllMagazineDto>>> Handle(GetAllMagazineQuery request, CancellationToken cancellationToken)
        {
            var magazine = await _magazinePageRepository.GetAllMagazine();
            var result = _mapper.Map<List<GetAllMagazineDto>>(magazine);
            return new Response<List<GetAllMagazineDto>>(result);
            
        }
    }
}
