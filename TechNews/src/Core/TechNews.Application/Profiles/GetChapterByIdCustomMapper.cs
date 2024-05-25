using AutoMapper;
using Microsoft.AspNetCore.DataProtection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Podcast.Queries.GetChapterById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetChapterByIdCustomMapper : ITypeConverter<Chapter, GetChapterByIdDto>
    {
        private readonly IDataProtector _protector;

        public GetChapterByIdCustomMapper(IDataProtectionProvider provider)
        {
            _protector = provider.CreateProtector("");
        }
        public GetChapterByIdDto Convert(Chapter source, GetChapterByIdDto destination, ResolutionContext context)
        {
            Byte[] bytes;
            
            string path = Path.Combine("Files/", source.Audio);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var ms = new MemoryStream())
            {
                fileStream.CopyTo(ms)
;
                bytes = ms.ToArray();
            }
            GetChapterByIdDto dest = new GetChapterByIdDto()
            {
                ChapterId= source.ChapterId,
                ChapterDescription = source.ChapterDescription,
                Audio = bytes,
                ChapterTitle = source.ChapterTitle,
                ChapterNumber = source.ChapterNumber,
                FileName = source.Audio,
                
            };

            return dest;

        }
    }
}
