using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Magazines.Query.GetMagazineById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetMagazineByIdCustomMapper : ITypeConverter<SectionMaster, GetMagazineByIdDto>
    {
        private readonly IMapper _mapper;
        public GetMagazineByIdCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetMagazineByIdDto Convert(SectionMaster source, GetMagazineByIdDto destination, ResolutionContext context)
        {
            Byte[] bytes;
            Byte[] bytepdf;
            string path = Path.Combine("Files/", source.Image);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var ms = new MemoryStream())
            {
                fileStream.CopyTo(ms)
;
                bytes = ms.ToArray();
            }
            List<GetMagazineByIdStoreFileDto> mvp = new List<GetMagazineByIdStoreFileDto>();
            foreach (var item in source.StoredFiles)
            {

                string path2 = Path.Combine("Files/", item.StoredFilePath);
                FileStream fileStream2 = new FileStream(path2, FileMode.Open, FileAccess.Read);

                using (var ms = new MemoryStream())
                {
                    fileStream2.CopyTo(ms);
                    bytepdf = ms.ToArray();
                    
                }
                GetMagazineByIdStoreFileDto sf = new GetMagazineByIdStoreFileDto();
                sf.StoredFileId = item.StoredFileId;
                sf.StoredFileName = item.StoredFileName;
                sf.StoredFilePath = bytepdf;
                sf.FileType = item.FileType;
                mvp.Add(sf);
            }

            GetMagazineByIdDto dest = new GetMagazineByIdDto()
            {
                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                TotalViews = (int)source.TotalViews,
                SectionMasterId = source.SectionMasterId,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType,
               MagazineId = source.Magzine.MagazineId,
               NumberOfPages = source.Magzine.NumberOfPages,
               LongDescription = source.Magzine.LongDescription,
               StoredFiles = mvp,
                CreatedDate = source.CreatedDate,
               Comments = _mapper.Map<ICollection<GetMagzineByIdCommentDto>>(source.Comments)
               

            };
            return dest;
        }
    }
}
