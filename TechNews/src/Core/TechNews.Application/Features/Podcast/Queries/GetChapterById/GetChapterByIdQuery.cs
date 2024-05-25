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

namespace TechNews.Application.Features.Podcast.Queries.GetChapterById
{
    public class GetChapterByIdQuery:IRequest<Response<GetChapterByIdDto>>
    {
        public int ChapterId { get; set; }

    }
}
