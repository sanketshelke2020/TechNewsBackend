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

namespace TechNews.Application.Features.Chapters.Query.ChapterNumberExist
{
    public class ChapterNumberExistHandler:IRequestHandler<ChapterNumberExistQuery,Response<bool>>
    {
        private readonly IMapper _mapper;
        private readonly IChapterRepository _chaptertRepository;
        private readonly ILogger<ChapterNumberExistHandler> _logger;

        public ChapterNumberExistHandler(IMapper mapper, IChapterRepository chapterRepository, ILogger<ChapterNumberExistHandler> logger)
        {
            _mapper = mapper;
            _chaptertRepository = chapterRepository;
            this._logger = logger;
        }

        public async Task<Response<bool>> Handle(ChapterNumberExistQuery request, CancellationToken cancellationToken)
        {
            bool result = await _chaptertRepository.ChapterNumberExist(request.ChapterNumber, request.PodcastId);

            return new Response<bool>(result);
        }
    }
}
