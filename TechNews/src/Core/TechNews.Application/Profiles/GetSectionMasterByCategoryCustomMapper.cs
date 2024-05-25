using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.HomePage.Queries.GetBreakingNews;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByCategory;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetSectionMasterByCategoryCustomMapper : ITypeConverter<SectionMaster, GetSectionMasterByCategoryQueryDto>
    {

        public GetSectionMasterByCategoryQueryDto Convert(SectionMaster source, GetSectionMasterByCategoryQueryDto destination, ResolutionContext context)
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
            GetSectionMasterByCategoryQueryDto dest = new GetSectionMasterByCategoryQueryDto()
            {
                SectionMasterId = source.SectionMasterId,
                ImageFile = bytes,
                Title = source.Title,
                TotalViews = (int)source.TotalViews,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType,
                Image = source.Image
            };

            return dest;

        }
    }
}
