using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Magazines.Query.GetAllMagazine;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetAllMagazineCustomMapper : ITypeConverter<SectionMaster, GetAllMagazineDto>
    {
        private readonly IMapper _mapper;
        public GetAllMagazineCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetAllMagazineDto Convert(SectionMaster source, GetAllMagazineDto destination, ResolutionContext context)
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

            GetAllMagazineDto dest = new GetAllMagazineDto()
            {
                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                TotalViews = (int)source.TotalViews,
                SectionMasterId = source.SectionMasterId,
               NumberOfPages = source.Magzine.NumberOfPages,
               CreatedDate = source.CreatedDate
            };
            return dest;
        }
    }
}
