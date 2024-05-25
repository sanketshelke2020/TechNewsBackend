using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByDate;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByKeyword;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetSectionMasterByDateCusotmeMapper : ITypeConverter<SectionMaster, GetSectionMasterByDateDto>
    {
        public GetSectionMasterByDateDto Convert(SectionMaster source, GetSectionMasterByDateDto destination, ResolutionContext context)
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
            GetSectionMasterByDateDto dest = new GetSectionMasterByDateDto()
            {
                SectionMasterId = source.SectionMasterId,
                Image = bytes,
                Title = source.Title,
                TotalViews = (int)source.TotalViews,
                ShortDescription = source.ShortDescription,
                CreatedDate = source.CreatedDate,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType
            };

            return dest;

        }
    }
}


