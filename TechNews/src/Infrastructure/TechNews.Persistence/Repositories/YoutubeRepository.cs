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
    public class YoutubeRepository : BaseRepository<YoutubeRepository>, IYoutubeRepository
    {
        private readonly ILogger<YoutubeRepository> _logger;

        public YoutubeRepository(ApplicationDbContext dbContext, ILogger<YoutubeRepository> logger) : base(dbContext, logger)
        {
        }

        public async Task<List<SectionMaster>> GetAllYoutube()
        {
            List<SectionMaster> sectionMasters = await _dbContext.SectionMasters.Include(y => y.Youtube).Include(s => s.StoredFiles).Where(t => t.CategoryType == "Youtube" && t.IsDeleted == false).ToListAsync();
            return sectionMasters;
        }

        public async Task<SectionMaster> GetYoutubeById(int id)
        {
            SectionMaster sectionMaster = await _dbContext.SectionMasters.Include(c => c.Youtube).Where(q => q.SectionMasterId == id).Include(q => q.Comments).Include(m => m.StoredFiles).FirstOrDefaultAsync();
            sectionMaster.TotalViews += 1;
            _dbContext.SaveChanges();
            return sectionMaster;
        }
    }
}
