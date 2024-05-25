using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Domain.Entities;
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace TechNews.Persistence.Repositories
{
    public class PodcastRepository : BaseRepository<Podcast>, IPodcastRepository
    {
        public PodcastRepository(ApplicationDbContext dbContext, ILogger<Podcast> logger) : base(dbContext, logger)
        {
        }
        public async Task<List<SectionMaster>> GetAllPodcast()
        {
            
           List<SectionMaster> SectionMaster  = await _dbContext.SectionMasters.Include(z => z.Podcast).Include(m => m.Podcast.Chapters).Include(k => k.Comments).Where(p => p.CategoryType == "Podcast").Where(q => q.IsDeleted == false).ToListAsync();
            return SectionMaster;
        }
        public async Task<SectionMaster> GetPodcastById(int id)
        {
            SectionMaster sectionMaster =  await _dbContext.SectionMasters.Where(z => z.SectionMasterId == id).Where(q => q.IsDeleted == false).Include(m => m.Podcast).Include(p => p.Comments).Include(q => q.Podcast.Chapters).FirstOrDefaultAsync();
            sectionMaster.TotalViews += 1;
            _dbContext.SaveChanges();
            return sectionMaster;
        }
        public async Task<Chapter> GetChapterById(int id)
        {   
            return await _dbContext.Chapters.Where(z => z.ChapterId == id).FirstOrDefaultAsync();
        }
    }
}
