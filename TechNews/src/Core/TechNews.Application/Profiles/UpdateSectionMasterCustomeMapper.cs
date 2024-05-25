using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.SectionMasters.Commands.UpdateSectionMaster;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class UpdateSectionMasterCustomeMapper : ITypeConverter<UpdateSectionMasterCommand, SectionMaster>
    {
        public SectionMaster Convert(UpdateSectionMasterCommand source, SectionMaster destination, ResolutionContext context)
        {
            SectionMaster dest = new SectionMaster()
            {
                SectionMasterId = source.SectionMasterId,
                //Image = SaveByteArrayToFileWithFileStream(source.Image, source.FileName),
                Image = source.FileName,
                Title = source.Title,
                ShortDescription = source.ShortDescription,
                TotalViews = (int)source.TotalViews,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType,
                LastModifiedDate = DateTime.Now,
                IsDeleted = false,
                CreatedDate = source.CreatedDate,
                StoredFiles = new List<StoredFile>()

            };
            if (source.Image != null)
            {
                dest.Image = SaveByteArrayToFileWithFileStream(source.Image, source.FileName);
            }
            if (source.File != null)
            {
                var name = SaveByteArrayToFileWithFileStream(source.File, source.StoredFileName);
                dest.StoredFiles.Add(new StoredFile()
                {
                    StoredFileId = source.StoredFileId,
                    SectionMasterId = source.SectionMasterId,
                    StoredFilePath = name,
                    FileType = Path.GetExtension(name),
                    StoredFileName = Path.GetFileNameWithoutExtension(name)
                }); ;
            }
            switch (source.CategoryType)
            {
                case "Youtube":
                    dest.Youtube = new Youtube()
                    {
                        YouTubeId = (int)source.CategoryId,
                        LongDescription = source.LongDescription,
                        YoutubeVideoLink = source.YoutubeVideoLink,
                        SectionMasterId = source.SectionMasterId
                    };
                    break;
                case "Article":
                    dest.Article = new Article()
                    {
                        ArticleId = (int)source.CategoryId,
                        SectionMasterId = source.SectionMasterId,
                        LongDescription = source.LongDescription,
                        ArticleCategoryId = source.ArticleCategoryId,
                        ArticleSubCategoryId = source.ArticleSubCategoryId,
                        CountryId = source.CountryId,
                        YoutubeVideoLink = source.YoutubeVideoLink
                    };
                    break;
                case "CaseStudies":
                    dest.CaseStudies = new CaseStudies()
                    {
                        CaseStudiesId = (int)source.CategoryId,
                        SectionMasterId = source.SectionMasterId,
                        LongDescription = source.LongDescription,
                        NumberOfChapter = source.NumberOfChapter
                    };
                    break;
                case "EventSchedule":
                    dest.EventSchedule = new EventSchedule()
                    {
                        EventScheduleId = (int)source.CategoryId,
                        SectionMasterId = source.SectionMasterId,
                        LongDescription = source.LongDescription,
                        EventTopic = source.EventTopic,
                        EventDate = source.EventDate,
                        SpeakerName = source.SpeakerName,
                        YoutubeVideoLink = source.YoutubeVideoLink
                    };
                    break;
                case "LiveInterview":
                    dest.LiveInterview = new LiveInterview()
                    {
                        LiveInterviewId = (int)source.CategoryId,
                        SectionMasterId = source.SectionMasterId,
                        LongDescription = source.LongDescription,
                        YoutubeVideoLink = source.YoutubeVideoLink
                    };
                    break;
                case "Magazine":
                    dest.Magzine = new Magazine()
                    {
                        MagazineId = (int)source.CategoryId,
                        SectionMasterId = source.SectionMasterId,
                        LongDescription = source.LongDescription,
                        NumberOfPages = source.NumberOfPages
                    };
                    break;
                case "Podcast":

                    dest.Podcast = new Podcast()
                    {
                        PodcastId = (int)source.CategoryId,
                        SectionMasterId = source.SectionMasterId,
                        LongDescription = source.LongDescription,
                        SpeakerName = source.SpeakerName,
                    };
                    
                    break;
                case "Webinar":
                    dest.Webinar = new Webinar()
                    {
                        WebinarId = (int)source.CategoryId,
                        SectionMasterId = source.SectionMasterId,
                        LongDescription = source.LongDescription,
                        SpeakerName = source.SpeakerName,
                        Topic = source.EventTopic,
                        StartDate = source.StartDate,
                        EndDate = source.EndDate,
                        TotalSeat = source.TotalSeat,
                        YoutubeVideoLink = source.YoutubeVideoLink,
                        WebinarHolders = new List<WebinarHolder>()
                        {
                            new WebinarHolder()
                            {
                                WebinarId = (int)source.CategoryId,
                                WebinarHolderId = source.WebinarHolderId,
                                Name = source.Name,
                                Designation = source.Designation,
                                ContactNumber = source.ContactNumber,
                                Email = source.Email,
                            }
                        }
                    };
                    break;
            }
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
