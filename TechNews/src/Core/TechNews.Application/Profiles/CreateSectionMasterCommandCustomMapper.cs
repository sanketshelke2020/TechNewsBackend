//using AutoMapper;
//using Microsoft.AspNetCore.DataProtection;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Http.Internal;
//using Microsoft.Extensions.Hosting;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using TechNews.Application.Features.Events.Queries.GetEventsList;
//using TechNews.Application.Features.SectionMasters.Commands.CreateSectionMaster;
//using TechNews.Domain.Entities;

//namespace TechNews.Application.Profiles
//{
//    public class CreateSectionMasterCommandCustomMapper : ITypeConverter<CreateSectionMasterCommand,SectionMaster>
//    {
//        private readonly IDataProtector _protector;

//        public CreateSectionMasterCommandCustomMapper(IDataProtectionProvider provider)
//        {
//            _protector = provider.CreateProtector("");
//        }

//         SectionMaster ITypeConverter<CreateSectionMasterCommand, SectionMaster>.Convert(CreateSectionMasterCommand source, SectionMaster destination, ResolutionContext context)
//        {
            
//                SectionMaster dest = new SectionMaster()
//            {
                
               
//                Title = source.Title,
//                ShortDescription = source.ShortDescription,
//                TotalViews = 0,
//                KeyWords = source.KeyWords,
//                CategoryType = source.CategoryType,
//                CreatedDate = DateTime.Now,
//                IsDeleted = false,
//                StoredFiles = new List<StoredFile>()

//            };
//            if(source.File != null)
//            {
//                var name = SaveByteArrayToFileWithFileStream(source.File, source.StoredFileName);
//                dest.StoredFiles.Add(new StoredFile()
//                {
//                    StoredFilePath = name,
//                    FileType = Path.GetExtension(name),
//                    StoredFileName = Path.GetFileNameWithoutExtension(name)
//                });
//            }
//            switch (source.CategoryType)
//            {
//                case "Youtube":
//                    dest.Youtube = new Youtube()
//                    {
//                        LongDescription = source.LongDescription,
//                        YoutubeVideoLink = source.YoutubeVideoLink
//                    };
//                    break;
//                case "Article":
//                    dest.Article = new Article()
//                    {
//                        LongDescription = source.LongDescription,
//                        ArticleCategoryId = source.ArticleCategoryId,
//                        ArticleSubCategoryId = source.ArticleSubCategoryId,
//                        YoutubeVideoLink = source.YoutubeVideoLink,
//                        CountryId = source.CountryId
//                    };
//                    break;
//                case "CaseStudies":
//                    dest.CaseStudies = new CaseStudies()
//                    {
//                        LongDescription = source.LongDescription,
//                        NumberOfChapter = source.NumberOfChapter
//                    };
//                    break;
//                case "EventSchedule":
//                    dest.EventSchedule = new EventSchedule()
//                    {
//                        LongDescription = source.LongDescription,
//                        EventTopic = source.EventTopic,
//                        EventDate = source.EventDate,
//                        YoutubeVideoLink = source.YoutubeVideoLink,
//                        SpeakerName = source.SpeakerName
//                    };
//                    break;
//                case "LiveInterview":
//                    dest.LiveInterview = new LiveInterview()
//                    {
//                        LongDescription = source.LongDescription,
//                        YoutubeVideoLink = source.YoutubeVideoLink
//                    };
//                    break;
//                case "Magazine":
//                    dest.Magzine = new Magazine()
//                    {
//                        LongDescription = source.LongDescription,
//                        NumberOfPages = source.NumberOfPages
//                    };
//                    break;

//                case "Podcast":
//                    dest.Podcast = new Podcast()
//                    {
//                        LongDescription = source.LongDescription,
//                        SpeakerName = source.SpeakerName,
//                    };
//                    break;

//                case "Webinar":
//                    dest.Webinar = new Webinar()
//                    {
//                        LongDescription = source.LongDescription,
//                        SpeakerName = source.SpeakerName,
//                        Topic = source.EventTopic,
//                        StartDate = source.StartDate,
//                        EndDate = source.EndDate,
//                        TotalSeat = source.TotalSeat,
//                        YoutubeVideoLink = source.YoutubeVideoLink,
//                        WebinarHolders = new List<WebinarHolder>()
//                        {
//                            new WebinarHolder()
//                            {
//                                Name = source.Name,
//                                Designation = source.Designation,
//                                ContactNumber = source.ContactNumber,
//                                Email = source.Email
//                            }
//                        }
//                    };
//            break;
//            }
//            return dest;
//        }

//        public static string SaveByteArrayToFileWithFileStream(byte[] data, string filePath)
//{
//            string fileName = Path.GetFileNameWithoutExtension(filePath);
//            string extension = Path.GetExtension(filePath);
//            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
//            string path = Path.Combine("Files/", fileName);
//            //string path = Path.Combine("Files/", );
//            using var stream = File.Create(path);
//            stream.Write(data, 0, data.Length);
//            return fileName;
//}
//        private async Task<string> SaveImageAsync(IFormFile imageFile)
//        {
//            string wwwRootPath = "";
//            string fileName = Path.GetFileNameWithoutExtension(imageFile.FileName);
//            string extension = Path.GetExtension(imageFile.FileName);
//            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
//            string path = Path.Combine("Files/", fileName);
//            using (var fileStream = new FileStream(path, FileMode.Create))
//            {
//                await imageFile.CopyToAsync(fileStream);
//            }
//            return fileName;
//        }

//    }
//}
