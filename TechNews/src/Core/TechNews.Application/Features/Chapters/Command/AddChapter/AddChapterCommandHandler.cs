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

namespace TechNews.Application.Features.Chapters.Command.AddChapter
{
    public class AddChapterCommandHandler : IRequestHandler<AddChapterCommand, Response<AddChapterCommandDto>>
    {
        private readonly IMapper _mapper;
        private readonly IChapterRepository _chaptertRepository;
        private readonly ILogger<AddChapterCommandHandler> _logger;

        public AddChapterCommandHandler(IMapper mapper, IChapterRepository chapterRepository, ILogger<AddChapterCommandHandler> logger)
        {
            _mapper = mapper;
            _chaptertRepository = chapterRepository;
            this._logger = logger;
        }
        public async Task<Response<AddChapterCommandDto>> Handle(AddChapterCommand request, CancellationToken cancellationToken)
        {
            var chapter = await _chaptertRepository.AddAsync(_mapper.Map<Chapter>(request));
            var result = _mapper.Map<AddChapterCommandDto>(chapter);
            return new Response<AddChapterCommandDto>(result);
        }
    }
}
