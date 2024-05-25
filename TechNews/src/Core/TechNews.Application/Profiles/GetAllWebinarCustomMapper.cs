using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Webinar.Queries.GetAllWebinar;
using TechNews.Application.Features.Youtube.Queries.GetAllYoutube;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetAllWebinarCustomMapper : ITypeConverter<SectionMaster, GetAllWebinarQueryDto>
    {
        private readonly IMapper _mapper;
        public GetAllWebinarCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetAllWebinarQueryDto Convert(SectionMaster source, GetAllWebinarQueryDto destination, ResolutionContext context)
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
            GetAllWebinarQueryDto result = new GetAllWebinarQueryDto
            {
                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                LongDescription = source.Webinar.LongDescription,
                TotalViews = (int)source.TotalViews,
                SectionMasterId = source.SectionMasterId,
                KeyWords = source.KeyWords,
                StartDate= source.Webinar.StartDate,
                EndDate= source.Webinar.EndDate,
                CategoryType = source.CategoryType,
                YoutubeVideoLink = source.Webinar.YoutubeVideoLink,
            };
            return result;  
        }
    }
}
