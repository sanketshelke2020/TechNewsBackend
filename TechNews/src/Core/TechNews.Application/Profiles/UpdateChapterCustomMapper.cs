using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Chapters.Command.UpdateChapter;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class UpdateChapterCustomMapper: ITypeConverter<UpdateChapterCommand, Chapter>
    {
        public Chapter Convert(UpdateChapterCommand source, Chapter destination, ResolutionContext context)
        {

            Chapter dest = new Chapter()
            { 
                ChapterId = source.ChapterId,
                Audio = SaveByteArrayToFileWithFileStream(source.Audio, source.FileName),
                ChapterTitle = source.ChapterTitle,
                ChapterDescription = source.ChapterDescription,
                ChapterNumber = source.ChapterNumber,
                PodcastId = source.PodcastId
            };
            return dest;
        }

        public static string SaveByteArrayToFileWithFileStream(byte[] data, string filePath)
        {
            string fileName = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            string path = Path.Combine("Files/", fileName);
            //string path = Path.Combine("Files/", );
            using var stream = File.Create(path);
            stream.Write(data, 0, data.Length);
            return fileName;
        }
    }
}
