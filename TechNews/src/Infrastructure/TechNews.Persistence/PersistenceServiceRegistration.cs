using TechNews.Application.Contracts.Persistence;
using TechNews.Infrastructure.EncryptDecrypt;
using TechNews.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TechNews.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("ApplicationConnectionString")));
            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IMessageRepository, MessageRepository>();
            services.AddScoped<IGuestUserRepository, GuestUserRepository>();

            services.AddScoped<IForgotPassword, ForgotPasswordRepository>();

            services.AddScoped<IForgotPassword, ForgotPasswordRepository>();
            services.AddScoped<IHomePageRepository, HomePageRepository>();
            services.AddScoped<INewsLetterRepository, NewsLetterRepository>();


            services.AddScoped<ILoginService, LoginService>();
            services.AddScoped<IUserRepository, UserRepository>();



            services.AddScoped<IRegisterRepository, RegisterRepository>();
            services.AddScoped<IArticleRepository, ArticleRepository>();
            services.AddScoped<ISectionMasterRepository, SectionMasterRepository>();
            services.AddScoped<IPodcastRepository, PodcastRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddScoped<IEventScheduleRepository, EventScheduleRepository>();
            services.AddScoped<IMagazineRepository, MagazineRepository>();
            services.AddScoped<IChapterRepository, ChapterRepository>();
            services.AddScoped<IStoredFileRepository, StoredFileRepository>();
            services.AddScoped<ILiveInterviewRepository, LiveInterviewRepository>();

            services.AddScoped<ICaseStudiesRepository, CaseStudiesRepository>();
            services.AddScoped<IYoutubeRepository, YoutubeRepository>();
            services.AddScoped<IWebinarRepository, WebinarRepository>();
            services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();
            services.AddScoped<IQueriesrespository, QueriesRepository>();
            services.AddScoped<IDynamicFieldRepository, DynamicFieldRepository>();

            
            return services;
        }
    }
}
