    using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Domain.Entities;

namespace TechNews.Persistence.Repositories
{
    public class ChapterRepository : BaseRepository<Chapter>, IChapterRepository
    {
        public ChapterRepository(ApplicationDbContext dbContext, ILogger<Chapter> logger) : base(dbContext, logger)
        {
        }
        public async Task<List<Chapter>> GetAllChapterByPodcastId(int id)
        {
            return await _dbContext.Chapters.Where(z => z.PodcastId == id).ToListAsync();
        }
        public async Task<Chapter> GetChapterById(int id)
        {
            return await _dbContext.Chapters.Where(a => a.ChapterId == id).FirstOrDefaultAsync();
        }
        public async Task<bool> ChapterNumberExist(int no , int podcastId)
        {

            var result = await _dbContext.Chapters.Where(z => z.ChapterNumber == no).Where(q => q.PodcastId == podcastId).FirstOrDefaultAsync();

            if (result == null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
