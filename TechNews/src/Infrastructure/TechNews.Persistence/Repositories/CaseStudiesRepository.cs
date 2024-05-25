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
    public class CaseStudiesRepository : BaseRepository<CaseStudiesRepository>, ICaseStudiesRepository
    {
        private readonly ILogger<CaseStudiesRepository> _logger;

        public CaseStudiesRepository(ApplicationDbContext dbContext, ILogger<CaseStudiesRepository> logger) : base(dbContext, logger)
        {
        }

        public async Task<List<SectionMaster>> GetAllCaseStudies()
        {
            List<SectionMaster> sectionMasters = await _dbContext.SectionMasters.Include(c=>c.CaseStudies).Where(p => p.CategoryType == "CaseStudies").ToListAsync();
            
            return sectionMasters;
        }

        public async Task<SectionMaster> GetCaseStudiesById(int id)
        {
            SectionMaster sectionMaster= await _dbContext.SectionMasters.Include(c=>c.CaseStudies).Where(q => q.SectionMasterId == id).Include(q => q.Comments).Include(m => m.StoredFiles).FirstOrDefaultAsync();
            sectionMaster.TotalViews += 1;
            _dbContext.SaveChanges();
            return sectionMaster;
        }
    }
}
