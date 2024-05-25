using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetSectionMasterByIdCustomeMapper : ITypeConverter<SectionMaster, GetSectionMasterByIdDto>
    {
        public GetSectionMasterByIdDto Convert(SectionMaster source, GetSectionMasterByIdDto destination, ResolutionContext context)
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
            GetSectionMasterByIdDto dest = new GetSectionMasterByIdDto()
            {
                SectionMasterId = source.SectionMasterId,
                Image = bytes,
                Title = source.Title,
                ShortDescription = source.ShortDescription,
                TotalViews = source.TotalViews,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType,
                FileName = source.Image,
                CreatedDate = source.CreatedDate
                //IsDeleted = false,


            };
            if (source.StoredFiles.Count != 0)
            {
                Byte[] storedFile;
                dest.StoredFileName = source.StoredFiles.FirstOrDefault().StoredFilePath;
                string path2 = Path.Combine("Files/",dest.StoredFileName);
                FileStream fileStream2 = new FileStream(path2, FileMode.Open, FileAccess.Read);

                using (var ms = new MemoryStream())
                {
                    fileStream2.CopyTo(ms)
    ;
                    storedFile = ms.ToArray();
                }
                dest.File = storedFile;
                dest.StoredFileId = source.StoredFiles.FirstOrDefault().StoredFileId;
            }
            switch (source.CategoryType)
            {
                case "Youtube":
                    dest.CategoryId = source.Youtube.YouTubeId;
                    dest.LongDescription = source.Youtube.LongDescription;
                    dest.YoutubeVideoLink = source.Youtube.YoutubeVideoLink;
                    break;
                case "Article":
                    dest.CategoryId = source.Article.ArticleId;
                    dest.LongDescription = source.Article.LongDescription;
                    dest.ArticleCategoryId = source.Article.ArticleCategoryId;
                    dest.ArticleSubCategoryId = source.Article.ArticleSubCategoryId;
                    dest.CountryId = source.Article.CountryId;
                    dest.YoutubeVideoLink = source.Article.YoutubeVideoLink;
                    break;
                case "CaseStudies":
                    dest.CategoryId = source.CaseStudies.CaseStudiesId;
                    dest.LongDescription = source.CaseStudies.LongDescription;
                    dest.NumberOfChapter = source.CaseStudies.NumberOfChapter;
                    break;
                case "EventSchedule":
                    dest.CategoryId = source.EventSchedule.EventScheduleId;
                        dest.LongDescription = source.EventSchedule.LongDescription;
                    dest.EventTopic = source.EventSchedule.EventTopic;
                    dest.EventDate = source.EventSchedule.EventDate;
                    dest.SpeakerName = source.EventSchedule.SpeakerName;
                    dest.YoutubeVideoLink = source.EventSchedule.YoutubeVideoLink;
                    break;
                case "LiveInterview":
                    dest.CategoryId = source.LiveInterview.LiveInterviewId;
                        dest.LongDescription = source.LiveInterview.LongDescription;
                    dest.YoutubeVideoLink = source.LiveInterview.YoutubeVideoLink;
                    break;
                case "Magazine":
                    dest.CategoryId = source.Magzine.MagazineId;
                    dest.LongDescription = source.Magzine.LongDescription;
                    dest.NumberOfPages = source.Magzine.NumberOfPages;
                    break;
                case "Podcast":
                    dest.CategoryId = source.Podcast.PodcastId;
                    dest.LongDescription = source.Podcast.LongDescription;
                    dest.SpeakerName = source.Podcast.SpeakerName;
                    dest.PodcastId = source.Podcast.PodcastId;
                    break;
                case "Webinar":
                    dest.CategoryId = source.Webinar.WebinarId; 
                    dest.WebinarHolderId = source.Webinar.WebinarHolders.First().WebinarHolderId;
                    dest.YoutubeVideoLink = source.Webinar.YoutubeVideoLink;
                    dest.LongDescription = source.Webinar.LongDescription;
                    dest.SpeakerName = source.Webinar.SpeakerName;
                    dest.EventTopic = source.Webinar.Topic;
                    dest.StartDate = source.Webinar.StartDate;
                    dest.EndDate = source.Webinar.EndDate;
                    dest.TotalSeat = source.Webinar.TotalSeat;
                    dest.Name = source.Webinar.WebinarHolders.First().Name;
                    dest.Designation = source.Webinar.WebinarHolders.First().Designation;
                    dest.ContactNumber = source.Webinar.WebinarHolders.First().ContactNumber;
                    dest.Email = source.Webinar.WebinarHolders.First().Email;
                    break;
            }
            return dest;
        }

        //public static string SaveByteArrayToFileWithFileStream(byte[] data, string filePath)
        //{
        //    string fileName = Path.GetFileNameWithoutExtension(filePath);
        //    string extension = Path.GetExtension(filePath);
        //    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
        //    string path = Path.Combine("Files/", fileName);
        //    //string path = Path.Combine("Files/", );
        //    using var stream = File.Create(path);
        //    stream.Write(data, 0, data.Length);
        //    return fileName;
        //}
        //private async Task<string> SaveImageAsync(IFormFile imageFile)
        //{
        //    string wwwRootPath = "";
        //    string fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
        //    string extension = Path.GetExtension(imageFile.FileName);
        //    fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
        //    string path = Path.Combine("Files/", fileName);
        //    using (var fileStream = new FileStream(path, FileMode.Create))
        //    {
        //        await imageFile.CopyToAsync(fileStream);
        //    }
        //    return fileName;
        //}

    }
}
