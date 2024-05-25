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

namespace TechNews.Application.Features.NewsLetters.Command.AddNewsLetter
{
    public class AddNewsLetterCommandHandler : IRequestHandler<AddNewsLetterCommand, Response<AddNewsLetterDto>>
    {
        private readonly IMapper _mapper;
        private readonly INewsLetterRepository _homePageRepository;
        private readonly ILogger<AddNewsLetterCommandHandler> _logger;

        public AddNewsLetterCommandHandler(IMapper mapper, INewsLetterRepository homePageRepository, ILogger<AddNewsLetterCommandHandler> logger)
        {
            _mapper = mapper;
            _homePageRepository = homePageRepository;
            this._logger = logger;
        }

        public  async Task<Response<AddNewsLetterDto>> Handle(AddNewsLetterCommand request, CancellationToken cancellationToken)
        {
            var newsletter = _mapper.Map<NewsLetter>(request);
            var result = await _homePageRepository.AddAsync(newsletter);
            var response = new Response<AddNewsLetterDto>(_mapper.Map<AddNewsLetterDto>(result));
            return response;
        }
    }
}
