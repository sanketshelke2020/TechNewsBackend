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

namespace TechNews.Application.Features.NewsLetters.Query.NewsLetterEmailExist
{
    public class NewsLetterEmailExistHandler:IRequestHandler<NewsLetterEmailExistQuery,Response<bool>>
    {
        private readonly IMapper _mapper;
        private readonly INewsLetterRepository _newsLetterRepository;
        private readonly ILogger<NewsLetterEmailExistHandler> _logger;

        public NewsLetterEmailExistHandler(IMapper mapper, INewsLetterRepository newsLetterRepository, ILogger<NewsLetterEmailExistHandler> logger)
        {
            _mapper = mapper;
            _newsLetterRepository = newsLetterRepository;
            this._logger = logger;
        }

        public async Task<Response<bool>> Handle(NewsLetterEmailExistQuery request, CancellationToken cancellationToken)
        {
            bool result = await _newsLetterRepository.NewsLetterEmailExist(request.Email);
            return new Response<bool>(result);
        }
    }
}
