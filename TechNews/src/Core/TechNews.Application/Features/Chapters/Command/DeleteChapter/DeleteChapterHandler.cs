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

namespace TechNews.Application.Features.Chapters.Command.DeleteChapter
{
    public class DeleteChapterHandler:IRequestHandler<DeleteChapterQuery,Response<DeleteChapterDto>>
    {
        private readonly IMapper _mapper;
        private readonly IChapterRepository _chaptertRepository;
        private readonly ILogger<DeleteChapterHandler> _logger;

        public DeleteChapterHandler(IMapper mapper, IChapterRepository chapterRepository, ILogger<DeleteChapterHandler> logger)
        {
            _mapper = mapper;
            _chaptertRepository = chapterRepository;
             this._logger = logger;
        }

        public async Task<Response<DeleteChapterDto>> Handle(DeleteChapterQuery request, CancellationToken cancellationToken)
        {
            var chapter = await _chaptertRepository.GetChapterById(request.ChapterId);
            if(chapter == null)
            {
                throw new Exception("Not found chapter by that name");
            }
            else{
                _chaptertRepository.DeleteAsync(chapter);
            }
            var response = _mapper.Map<DeleteChapterDto>(chapter);
            return new Response<DeleteChapterDto>(response);
        }
    }
}
