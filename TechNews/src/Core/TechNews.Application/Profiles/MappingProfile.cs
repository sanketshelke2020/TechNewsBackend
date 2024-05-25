using AutoMapper;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Features.CaseStudies.Queries.GetAllCaseStudies;
using TechNews.Application.Features.CaseStudies.Queries.GetCaseStudiesById;
using TechNews.Application.Features.Categories.Commands.CreateCategory;
using TechNews.Application.Features.Categories.Commands.StoredProcedure;
using TechNews.Application.Features.Categories.Queries.GetCategoriesList;
using TechNews.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using TechNews.Application.Features.Chapters.Command.AddChapter;
using TechNews.Application.Features.Chapters.Command.DeleteChapter;
using TechNews.Application.Features.Chapters.Command.UpdateChapter;
using TechNews.Application.Features.Chapters.Query.GetAllChapterByPodcast;
using TechNews.Application.Features.Comments.Command.AddComment;
using TechNews.Application.Features.DynamicFields.Command.AddDynamicField;
using TechNews.Application.Features.DynamicFields.Command.DeleteDynamicField;
using TechNews.Application.Features.DynamicFields.Command.UpdateDynamicField;
using TechNews.Application.Features.DynamicFields.Queries.GetAllDynamicField;
using TechNews.Application.Features.DynamicFields.Queries.GetDynamicFieldById;
using TechNews.Application.Features.DynamicFields.Query.GetDynamicFieldByCategoryQuery;
using TechNews.Application.Features.Events.Commands.CreateEvent;
using TechNews.Application.Features.Events.Commands.Transaction;
using TechNews.Application.Features.Events.Commands.UpdateEvent;
using TechNews.Application.Features.Events.Queries.GetEventDetail;
using TechNews.Application.Features.Events.Queries.GetEventsExport;
using TechNews.Application.Features.Events.Queries.GetEventsList;
using TechNews.Application.Features.EventSchedule.Queries.GetEventScheduleList;
using TechNews.Application.Features.EventSchedule.Queries.GetEventSheduleById;
using TechNews.Application.Features.GuestUsers.Commands.CreateGuestUser;
using TechNews.Application.Features.HomePage.Queries.GetBreakingNews;
using TechNews.Application.Features.HomePage.Queries.TreandingVideo;
using TechNews.Application.Features.LiveInterviews.Queries.GetListOfLiveInteriviews;
using TechNews.Application.Features.LiveInterviews.Queries.GetLiveInterviewById;
using TechNews.Application.Features.Magazines.Query.GetAllMagazine;
using TechNews.Application.Features.Magazines.Query.GetMagazineById;
using TechNews.Application.Features.NewsLetters.Command.AddNewsLetter;
using TechNews.Application.Features.NewsLetters.Query.NewsLetterEmailExist;
using TechNews.Application.Features.Orders.GetOrdersForMonth;
using TechNews.Application.Features.Podcast.Queries.GetAllpodcast;
using TechNews.Application.Features.Podcast.Queries.GetChapterById;
using TechNews.Application.Features.Podcast.Queries.GetPodcastById;
using TechNews.Application.Features.Register.Command.AddUser;
using TechNews.Application.Features.Register.Command.UpdateUser;
using TechNews.Application.Features.Register.Query.GetUserById;
using TechNews.Application.Features.SectionMasters.Commands.CreateSectionMaster;
using TechNews.Application.Features.SectionMasters.Commands.UpdateSectionMaster;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByCategory;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByDate;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterById;
using TechNews.Application.Features.SectionMasters.Queries.GetSectionMasterByKeyword;
using TechNews.Application.Features.UserQueries.Command;
using TechNews.Application.Features.UserQueries.Query.GetAllUserQuery;
using TechNews.Application.Features.UserQueries.Query.GetUserQueryById;
using TechNews.Application.Features.Webinar.Command;
using TechNews.Application.Features.Webinar.Queries.GetAllEnrolledUser;
using TechNews.Application.Features.Webinar.Queries.GetAllWebinar;
using TechNews.Application.Features.Webinar.Queries.GetWebinarById;
using TechNews.Application.Features.Webinar.Queries.GetYoutubeById;
using TechNews.Application.Features.Youtube.Queries.GetAllYoutube;
using TechNews.Application.Features.Youtube.Queries.GetYoutubeById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {          
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, TransactionCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
            CreateMap<Event, EventExportDto>().ReverseMap();
            CreateMap<GuestUser, CreateGuestUserCommand>().ReverseMap();
            CreateMap<GuestUser, GuestUserDto>().ReverseMap();
            CreateMap<User, AddUserCommand>().ReverseMap();
            CreateMap<User, AddUserCommandDto>().ReverseMap();
            CreateMap<Article, GetAllArticleQuery>().ReverseMap();
            CreateMap<Article, GetAllArticleQueryDto>().ReverseMap();
            CreateMap<StoredFile, ArticleStoreFileDto>().ReverseMap();


            CreateMap<Youtube, GetAllYoutubeQuery>().ReverseMap();
            CreateMap<Youtube, GetAllYoutubeQueryDto>().ReverseMap();
            CreateMap<StoredFile, YoutubeStoredFileDto>().ReverseMap();


            CreateMap<Webinar, GetAllWebinarQuery>().ReverseMap();
            CreateMap<Webinar, GetAllWebinarQueryDto>().ReverseMap();


            CreateMap<Enrollment, AddEnrollmentCommand>().ReverseMap();
            CreateMap<Enrollment, AddEnrollmentCommandDto>().ReverseMap();


            CreateMap<Enrollment, GetAllEnrolledUserQuery>().ReverseMap();
            CreateMap<Enrollment, GetAllEnrolledUserQueryDto>().ReverseMap();


            CreateMap<DynamicField, AddDynamicFieldCommand>().ReverseMap();
            CreateMap<DynamicField, AddDynamicFieldCommandDto>().ReverseMap();

            //CreateMap<DynamicField, GetFieldByCategoryQuery>().ReverseMap();
            //CreateMap<DynamicField, GetFieldByCategoryQueryDto>().ReverseMap();



            CreateMap<DynamicField, GetAllDynamicFieldQuery>().ReverseMap();

            CreateMap<DynamicField, GetAllDynamicFieldQueryDto>().ReverseMap();



            CreateMap<DynamicField, DeleteDynamicFieldCommand>().ReverseMap();
            CreateMap<DynamicField, DeleteDynamicFieldCommandDto>().ReverseMap();

            CreateMap<DynamicField, UpdateDynamicFieldCommand>().ReverseMap();
            CreateMap<DynamicField, UpdateDynamicFieldCommandDto>().ReverseMap();


            CreateMap<DynamicField, GetDynamicFieldByIdQuerie>().ReverseMap();
            CreateMap<DynamicField, GetDynamicFieldByIdQuerieDto>().ReverseMap();








            CreateMap<SectionMaster, GetAllYoutubeQueryDto>().ConvertUsing<GetAllYoutubeCustomMapper>();

            CreateMap<SectionMaster, GetYoutubeByIdQueryDto>().ConvertUsing<GetYoutubeByIdCustomMapper>();


            //CreateMap<SectionMaster, GetAllYoutubeQueryDto>().ConvertUsing<GetAllYoutubeCustomMapper>();



            CreateMap<SectionMaster, GetAllArticleQueryDto>().ConvertUsing<GetAllArticleCustomMapper>();
            CreateMap<SectionMaster, GetArticleByIdQueryDto>().ConvertUsing<GetArticleByIdCustomMapper>();

            CreateMap<CaseStudies, GetAllCaseStudiesQuery>().ReverseMap();
            //CreateMap<CaseStudies, GetAllCaseStudiesQueryDto>().ReverseMap();
            CreateMap<SectionMaster, GetAllCaseStudiesQueryDto>().ConvertUsing<GetAllCaseStudiesCustomMapper>();
            CreateMap<SectionMaster, GetLiveInterviewDto>().ConvertUsing<ListOfLiveInterviewCustomMapper>();
            CreateMap<SectionMaster, GetLiveInterviewByIdDto>().ConvertUsing<GetLiveInterviewByIdCustomeMapper>();
            

            CreateMap<SectionMaster, GetCaseStudiesByIdQueryDto>().ConvertUsing<GetCaseStudiesByIdCustomMapper>();

            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Category, CreateCategoryCommand>();
            CreateMap<Category, CreateCategoryDto>();
            CreateMap<Category, StoredProcedureCommand>();
            CreateMap<Category, StoredProcedureDto>();

            CreateMap<Order, OrdersForMonthDto>();

            CreateMap<Event, EventListVm>().ConvertUsing<EventVmCustomMapper>();

            CreateMap<SectionMaster, GetBreakingNewsDto>().ConvertUsing<GetBreakingNewsCustomMapper>();

            CreateMap<CreateSectionMasterCommand, SectionMaster>().ReverseMap();
            CreateMap<SectionMaster, GetSectionMasterByIdDto >().ConvertUsing<GetSectionMasterByIdCustomeMapper>();
            CreateMap<UpdateSectionMasterCommand, SectionMaster >().ConvertUsing<UpdateSectionMasterCustomeMapper>();
           

            CreateMap<NewsLetter,AddNewsLetterCommand>().ReverseMap();
            CreateMap<NewsLetter,AddNewsLetterDto>().ReverseMap();
            CreateMap<SectionMaster, GetTreandingVideoDto>().ReverseMap();
            CreateMap<SectionMaster, GetTreandingVideoQuery>().ReverseMap();
            
            CreateMap<SectionMaster, GetTreandingVideoDto>().ConvertUsing<GetTrendingVideoCustomMapper>();



            CreateMap<SectionMaster, GetAllPodcastQuery>().ReverseMap();
            CreateMap<SectionMaster,GetAllPodcastDto>().ConvertUsing<GetAllPodcastCustomMapper>();


            CreateMap<StoredFile, PodcastStoreFileDto>().ReverseMap();
            CreateMap<Comment, PodcastCommentDto>().ReverseMap();

            CreateMap<Chapter, PodcastChapterDto>().ReverseMap();
            CreateMap<Comment, AddCommentCommand>().ReverseMap();
            CreateMap<Comment, AddCommentCommandDto>().ReverseMap();
            CreateMap<Comment, GetPodcastByIdCommentDto>().ReverseMap();
            CreateMap<Comment, LiveInterviewCommentDto>().ReverseMap();
            CreateMap<Chapter, GetByIdPodcastChapterDto>().ReverseMap();

            CreateMap<SectionMaster, GetPodcastByIdQuery>().ReverseMap();
            CreateMap<SectionMaster,GetPodcastByIdDto>().ConvertUsing<GetPodcastByIdCustomMapper>();
            CreateMap<Chapter, GetChapterByIdDto>().ConvertUsing<GetChapterByIdCustomMapper>();
            



            CreateMap<SectionMaster, CreateSectionMasterDto>().ReverseMap();
            CreateMap<SectionMaster, GetSectionMasterByCategoryQuery>().ReverseMap();
            CreateMap<SectionMaster, GetSectionMasterByCategoryQueryDto>().ConvertUsing<GetSectionMasterByCategoryCustomMapper>();

            CreateMap<SectionMaster, EventScheduleListVm>().ConvertUsing<GetAllEventScheduleCustomMapper>();
            CreateMap<SectionMaster, GetSectionMasterByKeywordDto>().ConvertUsing<GetSectionMasterByKeywordCustomeMapper>();
            CreateMap<SectionMaster, GetSectionMasterByDateDto>().ConvertUsing<GetSectionMasterByDateCusotmeMapper>();
            

           
            CreateMap<SectionMaster, GetEventSheduleByIdDto>().ConvertUsing<GetEventSheduleByIdCustomMapper>();
            CreateMap<Comment, GetEventSheduleByIdCommentDto>().ReverseMap();

            CreateMap<Comment, GetArticleByIdCommentDto>().ReverseMap();
            CreateMap<Comment, GetCaseStudiesByIdCommentDto>().ReverseMap();

            CreateMap<NewsLetter, NewsLetterEmailExistQuery>().ReverseMap();
            CreateMap<SectionMaster, GetAllMagazineDto>().ConvertUsing<GetAllMagazineCustomMapper>();
            CreateMap<SectionMaster, GetMagazineByIdDto>().ConvertUsing<GetMagazineByIdCustomMapper>();
            CreateMap<StoredFile, GetMagazineByIdStoreFileDto>().ReverseMap();
            CreateMap<Comment, GetMagzineByIdCommentDto>().ReverseMap();
            CreateMap<AddChapterCommand,Chapter>().ConvertUsing<AddChapterCustomMapper>();
            CreateMap<Chapter, AddChapterCommandDto>().ReverseMap();
            CreateMap<Chapter, GetAllChapterByPodcastDto>().ConvertUsing<GetAllChapterByPodcastIdCustomMapper>();
            CreateMap<Chapter, DeleteChapterDto>().ReverseMap();
            CreateMap< UpdateChapterCommand, Chapter>().ConvertUsing<UpdateChapterCustomMapper>();
            CreateMap<Chapter, UpdateCommandDto>().ReverseMap();

            CreateMap<Comment, GetYoutubeByIdCommentDto>().ReverseMap();
            CreateMap<User, UpdateUserCommand>().ReverseMap();
            CreateMap<User, UpdateuserCommandDto>().ReverseMap();
            CreateMap<User, GetUserByIdQuery>().ReverseMap();
            CreateMap<User, GetUserByIdDto>().ReverseMap();
            
            CreateMap<Comment, GetWebinarByIdCommentDto>().ReverseMap();


            CreateMap<WebinarHolder, GetWebinarByIdWebinarHolderDto>().ReverseMap();


            CreateMap<SectionMaster, GetAllWebinarQueryDto>().ConvertUsing<GetAllWebinarCustomMapper>();
            CreateMap<SectionMaster, GetWebinarByIdQueryDto>().ConvertUsing<GetWebinarByIdCustomMapper>();

            CreateMap<Querie, AddUserQueryCommand>().ReverseMap();
            CreateMap<Querie, AddUserQueryCommandDto>().ReverseMap();
            CreateMap<Querie, AddUserQueryCommandHandler>().ReverseMap();


            CreateMap<Querie,GetAllUserQueriesDto>().ReverseMap();
            CreateMap<Querie,GetUserQueryByIdDto >().ConvertUsing<GetUserQueryByIdCustomMapper>();
            CreateMap<DynamicField, GetDynamicFieldByCategoryDto>().ConvertUsing<GetDynamicFieldByCategoryCustomMapper>();
            CreateMap<DynamicFormMultipleOption, MultipleOptionDto>().ReverseMap();

        }
    }
}
