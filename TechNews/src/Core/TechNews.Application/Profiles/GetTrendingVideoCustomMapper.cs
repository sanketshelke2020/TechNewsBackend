using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.HomePage.Queries.TreandingVideo;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetTrendingVideoCustomMapper: ITypeConverter<SectionMaster, GetTreandingVideoDto>
    {
        private readonly IMapper _mapper;
        public GetTrendingVideoCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetTreandingVideoDto Convert(SectionMaster source, GetTreandingVideoDto destination, ResolutionContext context)
        {
            //var result = _mapper.Map<List<StoredFile>>(destination.StoredFiles);

            Byte[] bytes;
            string path = Path.Combine("Files/", source.Image);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var ms = new MemoryStream())
            {
                fileStream.CopyTo(ms)
;
                bytes = ms.ToArray();
            }
            GetTreandingVideoDto dest = new GetTreandingVideoDto()
            {

                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                TotalViews = (int)source.TotalViews,
                SectionMasterId = source.SectionMasterId,
                CategoryType = source.CategoryType,
                YouTubeId = source.Youtube.YouTubeId,
                LongDescription = source.Youtube.LongDescription,
               
   
               
            };
            return dest;

        }
    }
}
