using AutoMapper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using TechNews.Application.Features.LiveInterviews.Queries.GetLiveInterviewById;
using TechNews.Application.Features.Podcast.Queries.GetPodcastById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetLiveInterviewByIdCustomeMapper : ITypeConverter<SectionMaster, GetLiveInterviewByIdDto>
    {
        private readonly IMapper _mapper;
        public GetLiveInterviewByIdCustomeMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetLiveInterviewByIdDto Convert(SectionMaster source, GetLiveInterviewByIdDto destination, ResolutionContext context)
        {
            Byte[] bytes;
            string path = Path.Combine("Files/", source.Image);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var ms = new MemoryStream())
            {
                fileStream.CopyTo(ms);
                bytes = ms.ToArray();
            }

            GetLiveInterviewByIdDto dest = new GetLiveInterviewByIdDto()
            {
                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                TotalViews = (int)source.TotalViews,
                CreatedDate = source.CreatedDate,
                YoutubeVideoLink = source.LiveInterview.YoutubeVideoLink,
                SectionMasterId = source.SectionMasterId,
                LiveInterviewId = source.LiveInterview.LiveInterviewId,
                LongDescription = source.LiveInterview.LongDescription,
                Comments = _mapper.Map<ICollection<LiveInterviewCommentDto>>(source.Comments)
            };
            return dest;
        }
    }
}
