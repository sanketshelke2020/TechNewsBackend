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

namespace TechNews.Application.Features.Chapters.Command.UpdateChapter
{
    public class UpdateChapterCommandHandler:IRequestHandler<UpdateChapterCommand,Response<UpdateCommandDto>>
    {
        private readonly IMapper _mapper;
        private readonly IChapterRepository _chaptertRepository;
        private readonly ILogger<UpdateChapterCommandHandler> _logger;

        public UpdateChapterCommandHandler(IMapper mapper, IChapterRepository chapterRepository, ILogger<UpdateChapterCommandHandler> logger)
        {
            _mapper = mapper;
            _chaptertRepository = chapterRepository;
            this._logger = logger;
        }

        public async Task<Response<UpdateCommandDto>> Handle(UpdateChapterCommand request, CancellationToken cancellationToken)
        {
            var chapter = _mapper.Map<Chapter>(request);
             await _chaptertRepository.UpdateAsync(chapter);
            var response = _mapper.Map<UpdateCommandDto>(chapter);
            return new Response<UpdateCommandDto>(response);
        }
    }
}
