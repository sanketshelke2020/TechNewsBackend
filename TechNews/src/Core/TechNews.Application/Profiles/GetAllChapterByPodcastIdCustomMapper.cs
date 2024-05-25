using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Chapters.Query.GetAllChapterByPodcast;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    internal class GetAllChapterByPodcastIdCustomMapper : ITypeConverter<Chapter, GetAllChapterByPodcastDto>
    {
        public GetAllChapterByPodcastDto Convert(Chapter source, GetAllChapterByPodcastDto destination, ResolutionContext context)
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
            GetAllChapterByPodcastDto dest = new GetAllChapterByPodcastDto()
            {
                Audio = bytes,
                ChapterDescription = source.ChapterDescription,
                ChapterId = source.ChapterId,
                ChapterTitle = source.ChapterTitle,
                ChapterNumber = source.ChapterNumber,
                PodcastId = source.PodcastId,




            };
            return dest;
        }
    }
}