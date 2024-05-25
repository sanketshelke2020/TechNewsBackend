using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.HomePage.Queries.GetBreakingNews;
using TechNews.Application.Features.LiveInterviews.Queries.GetListOfLiveInteriviews;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class ListOfLiveInterviewCustomMapper : ITypeConverter<SectionMaster,GetLiveInterviewDto>
    {
        public GetLiveInterviewDto Convert(SectionMaster source, GetLiveInterviewDto destination, ResolutionContext context)
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
            GetLiveInterviewDto dest = new GetLiveInterviewDto()
            {
                SectionMasterId = source.SectionMasterId,
                Image = bytes,
                Title = source.Title,
                TotalViews = (int)source.TotalViews,
                ShortDescription = source.ShortDescription,
                CreatedDate = source.CreatedDate
            };

            return dest;

        }
    }
}
