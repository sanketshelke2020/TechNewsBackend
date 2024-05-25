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

namespace TechNews.Application.Features.Comments.Command.AddComment
{
    public class AddCommentCommandHandler : IRequestHandler<AddCommentCommand, Response<AddCommentCommandDto>>
    {
        private readonly IMapper _mapper;
        private readonly ICommentRepository _commentRepository;
        private readonly ILogger<AddCommentCommandHandler> _logger;

        public AddCommentCommandHandler(IMapper mapper, ICommentRepository commnetRepository, ILogger<AddCommentCommandHandler> logger)
        {
            _mapper = mapper;
            _commentRepository = commnetRepository;
            this._logger = logger;
        }
        public  async Task<Response<AddCommentCommandDto>> Handle(AddCommentCommand request, CancellationToken cancellationToken)
        {
            _logger.LogInformation("AddCommentCommand Initiated");
            var comment = _mapper.Map<Comment>(request);
            var result =  await _commentRepository.AddAsync(comment);
            var response = _mapper.Map<AddCommentCommandDto>(result);
            return new Response<AddCommentCommandDto>(response);
            _logger.LogInformation("AddCommentCommand completed");

        }
    }
}
