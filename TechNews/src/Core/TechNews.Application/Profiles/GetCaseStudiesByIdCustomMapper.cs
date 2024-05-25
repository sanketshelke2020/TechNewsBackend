using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Features.CaseStudies.Queries.GetAllCaseStudies;
using TechNews.Application.Features.CaseStudies.Queries.GetCaseStudiesById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetCaseStudiesByIdCustomMapper : ITypeConverter<SectionMaster, GetCaseStudiesByIdQueryDto>
    {
        private readonly IMapper _mapper;
        public GetCaseStudiesByIdCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

        public GetCaseStudiesByIdQueryDto Convert(SectionMaster source, GetCaseStudiesByIdQueryDto destination, ResolutionContext context)
        {
            Byte[] bytes;
            Byte[] bytespdf;
            string path = Path.Combine("Files/", source.Image);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var ms = new MemoryStream())
            {
                fileStream.CopyTo(ms)
;
                bytes = ms.ToArray();
            }
            List<GetCaseStudiesByIdStoredFileDto> mvp = new List<GetCaseStudiesByIdStoredFileDto>();
            foreach (var item in source.StoredFiles)
            {

                string path2 = Path.Combine("Files/", item.StoredFilePath);
                FileStream fileStream2 = new FileStream(path2, FileMode.Open, FileAccess.Read);

                using (var ms = new MemoryStream())
                {
                    fileStream2.CopyTo(ms)

    ;
                    bytespdf = ms.ToArray();
                    Console.WriteLine(bytespdf);
                }
                GetCaseStudiesByIdStoredFileDto sf = new GetCaseStudiesByIdStoredFileDto();
                sf.StoredFileId = item.StoredFileId;
                sf.StoredFileName = item.StoredFileName;
                sf.StoredFilePath = bytespdf;
                sf.FileType = item.FileType;
                mvp.Add(sf);
            }
            GetCaseStudiesByIdQueryDto dest = new GetCaseStudiesByIdQueryDto
            {

                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                NumberOfChapter = source.CaseStudies.NumberOfChapter,
                LongDescription = source.CaseStudies.LongDescription,
                SectionMasterId = source.SectionMasterId,
                CaseStudiesId= source.CaseStudies.CaseStudiesId,
                StoredFiles = mvp,
                Comments = _mapper.Map<ICollection<GetCaseStudiesByIdCommentDto>>(source.Comments),
                TotalViews= (int)source.TotalViews,

            }; return dest;


        }
    }
}
