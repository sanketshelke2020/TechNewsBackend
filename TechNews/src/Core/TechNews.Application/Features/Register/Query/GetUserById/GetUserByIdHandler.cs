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

namespace TechNews.Application.Features.Register.Query.GetUserById
{
    public class GetUserByIdHandler:IRequestHandler<GetUserByIdQuery, Response<GetUserByIdDto>>
    {
        private readonly ILogger<GetUserByIdHandler> _logger;
        private readonly IRegisterRepository _registerRepository;
        private readonly IMapper _mapper;


        public GetUserByIdHandler(ILogger<GetUserByIdHandler> logger, IRegisterRepository registerRepository, IMapper mapper)
        {
            _logger = logger;
            _registerRepository = registerRepository;
            _mapper = mapper;

        }

        public async Task<Response<GetUserByIdDto>> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _registerRepository.GetUserById(request.UserId);
            var result = _mapper.Map<GetUserByIdDto>(user);
            return new Response<GetUserByIdDto>(result);
        }
    }
}
