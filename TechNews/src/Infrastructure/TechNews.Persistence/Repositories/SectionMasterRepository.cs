using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Exceptions;
using TechNews.Domain.Entities;

namespace TechNews.Persistence.Repositories
{
    public class SectionMasterRepository : BaseRepository<SectionMaster>, ISectionMasterRepository
    {
        public SectionMasterRepository(ApplicationDbContext dbContext, ILogger<SectionMaster> logger) : base(dbContext, logger)
        {
        }

        public async Task<bool> DeleteByIdAsync(int sectionMasterId)
        {
            SectionMaster sectionToDelete = await _dbContext.SectionMasters.FirstOrDefaultAsync(x => x.SectionMasterId == sectionMasterId);
            if (sectionToDelete == null)
            {
                throw new NotFoundException(nameof(Event), sectionToDelete);
            }
            sectionToDelete.IsDeleted = true;
            try
            {
                UpdateAsync(sectionToDelete);
            }
            catch (Exception)
            {
                return false;
            }
            return true;


        }

        public async Task<SectionMaster> GetSectionByIdAsync(int sectionMasterId)
        {
            var result = await _dbContext.SectionMasters
                .Include(x => x.Youtube)
                .Include(x => x.Podcast)
                .Include(x => x.Webinar.WebinarHolders)
                .Include(x => x.CaseStudies)
                .Include(x => x.LiveInterview)
                .Include(x => x.Article)
                .Include(x => x.Magzine)
                .Include(x => x.EventSchedule)
                .Include(x => x.StoredFiles)
                .FirstOrDefaultAsync(x => x.SectionMasterId == sectionMasterId);


            return result; 
        }

        public async Task<List<SectionMaster>> GetSectionMasterByCategory(string category)
        {
            List<SectionMaster> sectionMasters = await _dbContext.SectionMasters.Where(a => a.CategoryType == category && a.IsDeleted == false).ToListAsync();
            return sectionMasters;
        }

        public bool UpdateSection(SectionMaster section)
        {
            _dbContext.Update(section);
             var result = _dbContext.SaveChanges();
            if (result > 0)
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
