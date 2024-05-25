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
    public class HomePageRepository : BaseRepository<SectionMaster>, IHomePageRepository
    {
        public HomePageRepository(ApplicationDbContext dbContext, ILogger<SectionMaster> logger) : base(dbContext, logger)
        {
        }
        public List<SectionMaster> GetBreakingNews()
        {
            List<SectionMaster> breakingNews = _dbContext.SectionMasters.Where(t => t.CategoryType == "Article" && t.IsDeleted == false).Include(a => a.Article).OrderByDescending(z => z.CreatedDate).Take(5).ToList();
            return breakingNews;
        }
        public  async Task<List<SectionMaster>> GettreandingVideo()
        {
            List<SectionMaster> sectionMasters =  await _dbContext.SectionMasters.Include(v => v.Youtube).Where(t => t.CategoryType == "Youtube" && t.IsDeleted == false).OrderByDescending(p => p.TotalViews).Take(3).ToListAsync();
            return sectionMasters;
            
        }

       
    }
}
