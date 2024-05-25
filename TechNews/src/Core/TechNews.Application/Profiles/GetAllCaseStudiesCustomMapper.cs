using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Features.CaseStudies.Queries.GetAllCaseStudies;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetAllCaseStudiesCustomMapper :ITypeConverter<SectionMaster, GetAllCaseStudiesQueryDto>
    {
        private readonly IMapper _mapper;
        public GetAllCaseStudiesCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetAllCaseStudiesQueryDto Convert(SectionMaster source, GetAllCaseStudiesQueryDto destination, ResolutionContext context)
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
            GetAllCaseStudiesQueryDto dest = new GetAllCaseStudiesQueryDto
            {
                Title = source.Title,
                Image = bytes,
                TotalViews = (int)source.TotalViews,

                ShortDescription = source.ShortDescription,
                NumberOfChapter = source.CaseStudies.NumberOfChapter,
                LongDescription = source.CaseStudies.LongDescription,
                SectionMasterId = source.SectionMasterId,
                CaseStudiesId= source.CaseStudies.CaseStudiesId,
                StoredFiles = _mapper.Map<ICollection<CaseStudiesStoredFileDto>>(source.StoredFiles),


            };
            return dest;
        }
    }
}
