using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Features.Youtube.Queries.GetAllYoutube;
using TechNews.Application.Features.Youtube.Queries.GetYoutubeById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetAllYoutubeCustomMapper : ITypeConverter<SectionMaster, GetAllYoutubeQueryDto>
    {
        private readonly IMapper _mapper;
        public GetAllYoutubeCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetAllYoutubeQueryDto Convert(SectionMaster source, GetAllYoutubeQueryDto destination, ResolutionContext context)
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
            GetAllYoutubeQueryDto dest = new GetAllYoutubeQueryDto
            {


                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                LongDescription = source.Youtube.LongDescription,
                TotalViews = (int)source.TotalViews,
                SectionMasterId = source.SectionMasterId,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType,
               // StoredFiles = _mapper.Map<ICollection<YoutubeStoredFileDto>>(source.StoredFiles),
                YoutubeVideoLink = source.Youtube.YoutubeVideoLink,



            };
            return dest;
        }
    }
}
