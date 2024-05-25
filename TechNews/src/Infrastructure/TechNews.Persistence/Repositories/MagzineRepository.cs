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
    public class MagazineRepository : BaseRepository<Magazine>, IMagazineRepository
    {
        public MagazineRepository(ApplicationDbContext dbContext, ILogger<Magazine> logger) : base(dbContext, logger)
        {
        }

        public async Task<List<SectionMaster>> GetAllMagazine()
        {

            List<SectionMaster> SectionMaster = await _dbContext.SectionMasters.Where(p => p.CategoryType == "Magazine").Where(q => q.IsDeleted == false).Include(z => z.Magzine).ToListAsync();
            return SectionMaster;
        }
        public async Task<SectionMaster> GetMagazineById(int id)
        {
            SectionMaster sectionMaster = await _dbContext.SectionMasters.Where(a => a.SectionMasterId == id).Include(s => s.Comments).Where(q => q.IsDeleted == false).Include(z => z.Magzine).Include(p => p.StoredFiles).FirstOrDefaultAsync();
            sectionMaster.TotalViews += 1;
            _dbContext.SaveChanges();
            return sectionMaster;
            
        }
    }
}
