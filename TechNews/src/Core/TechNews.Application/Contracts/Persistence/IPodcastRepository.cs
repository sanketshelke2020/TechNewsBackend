using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IPodcastRepository:IAsyncRepository<Podcast>
    {
        Task<List<SectionMaster>> GetAllPodcast();
        Task<SectionMaster> GetPodcastById(int id);
        Task<Chapter> GetChapterById(int id);
    }
}
