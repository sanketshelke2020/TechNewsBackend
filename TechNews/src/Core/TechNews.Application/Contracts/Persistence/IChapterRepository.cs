using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IChapterRepository:IAsyncRepository<Chapter>
    {
        Task<List<Chapter>> GetAllChapterByPodcastId(int id);
        Task<Chapter> GetChapterById(int id);
        Task<bool> ChapterNumberExist(int no, int podcastId);
    }
}
