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
    public class GetBreakingNewsCustomMapper:ITypeConverter<SectionMaster, GetBreakingNewsDto>
    {
        public GetBreakingNewsDto Convert(SectionMaster source, GetBreakingNewsDto destination, ResolutionContext context)
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
            GetBreakingNewsDto dest = new GetBreakingNewsDto()
            {
                SectionMasterId = source.SectionMasterId,
                Image = bytes,
                ArticleId = source.Article.ArticleId,
                Title = source.Title,
                TotalViews = (int)source.TotalViews

            };

            return dest;

        }
    }
}
