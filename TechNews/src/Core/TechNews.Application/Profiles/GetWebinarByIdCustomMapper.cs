using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Webinar.Queries.GetWebinarById;
using TechNews.Application.Features.Webinar.Queries.GetYoutubeById;
using TechNews.Application.Features.Youtube.Queries.GetYoutubeById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetWebinarByIdCustomMapper : ITypeConverter<SectionMaster, GetWebinarByIdQueryDto>
    {
        private readonly IMapper _mapper;
        public GetWebinarByIdCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetWebinarByIdQueryDto Convert(SectionMaster source, GetWebinarByIdQueryDto destination, ResolutionContext context)
        {
            Byte[] bytes;
            string path = Path.Combine("Files/", source.Image);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var ms = new MemoryStream())
            {
                fileStream.CopyTo(ms)
;
                bytes = ms.ToArray();
            }
            GetWebinarByIdQueryDto result = new GetWebinarByIdQueryDto
            {
                WebinarId=source.Webinar.WebinarId,
                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                LongDescription = source.Webinar.LongDescription,
                TotalViews = (int)source.TotalViews,
                SectionMasterId = source.SectionMasterId,
                Topic= source.Webinar.Topic,
                TotalSeat= source.Webinar.TotalSeat,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType,
                YoutubeVideoLink = source.Webinar.YoutubeVideoLink,
                SpeakerName= source.Webinar.SpeakerName,
                StartDate=source.Webinar.StartDate,
                EndDate=source.Webinar.EndDate,
                Comments = _mapper.Map<ICollection<GetWebinarByIdCommentDto>>(source.Comments),
                WebinarHolders= _mapper.Map<ICollection<GetWebinarByIdWebinarHolderDto>>(source.Webinar.WebinarHolders),
            };
            return result;  

        }
    }
}
