using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.LiveInterviews.Queries.GetListOfLiveInteriviews;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByKeyword;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetSectionMasterByKeywordCustomeMapper : ITypeConverter<SectionMaster,GetSectionMasterByKeywordDto>
    {
        public GetSectionMasterByKeywordDto Convert(SectionMaster source, GetSectionMasterByKeywordDto destination, ResolutionContext context)
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
            GetSectionMasterByKeywordDto dest = new GetSectionMasterByKeywordDto()
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

  