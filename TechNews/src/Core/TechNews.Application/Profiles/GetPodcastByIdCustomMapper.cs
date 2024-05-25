﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Podcast.Queries.GetPodcastById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetPodcastByIdCustomMapper: ITypeConverter<SectionMaster, GetPodcastByIdDto>
    {

        private readonly IMapper _mapper;
        public GetPodcastByIdCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetPodcastByIdDto Convert(SectionMaster source, GetPodcastByIdDto destination, ResolutionContext context)
        {
            Byte[] bytes;
            Byte[] byteaudio;
            string path = Path.Combine("Files/", source.Image);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var ms = new MemoryStream())
            {
                fileStream.CopyTo(ms)
;
                bytes = ms.ToArray();
            }
            List<GetByIdPodcastChapterDto> chapterbyte = new List<GetByIdPodcastChapterDto>();
            
            foreach (var item in source.Podcast.Chapters)
            {
                string path2 = Path.Combine("Files/", item.Audio);
                FileStream fileStream2 = new FileStream(path2, FileMode.Open, FileAccess.Read);

                using (var ms = new MemoryStream())
                {
                    fileStream2.CopyTo(ms)
    ;
                    byteaudio = ms.ToArray();
                    Console.WriteLine(byteaudio);
                }
                GetByIdPodcastChapterDto adder = new GetByIdPodcastChapterDto();
                adder.ChapterDescription = item.ChapterDescription;
                adder.Audio = byteaudio;
                adder.ChapterTitle = item.ChapterTitle;
                adder.ChapterId = item.ChapterId;
                adder.ChapterNumber = item.ChapterNumber;
                adder.PodcastId = item.PodcastId;
                chapterbyte.Add(adder);

                Console.WriteLine(adder);

            }

            GetPodcastByIdDto dest = new GetPodcastByIdDto()
            {

                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                TotalViews = (int)source.TotalViews,
                SectionMasterId = source.SectionMasterId,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType,
                PodcastId = source.Podcast.PodcastId,
                LongDescription = source.Podcast.LongDescription,
                SpeakerName = source.Podcast.SpeakerName,
                Chapters = chapterbyte,
                Comment = _mapper.Map<ICollection<GetPodcastByIdCommentDto>>(source.Comments)


            };
            return dest;
        }
    }
}