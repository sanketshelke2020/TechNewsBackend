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
    public class EventScheduleRepository : BaseRepository<EventSchedule>, IEventScheduleRepository
    {
        private readonly ILogger<EventScheduleRepository> _logger;
        public EventScheduleRepository(ApplicationDbContext dbContext, ILogger<EventSchedule> logger) : base(dbContext, logger)
        {
            
        }

        public async Task<List<SectionMaster>> GetAllEventSchedule()
        {

            List<SectionMaster> sectionMaster = await _dbContext.SectionMasters.Include(z => z.EventSchedule).Include(m => m.StoredFiles).Where(p => p.CategoryType == "EventSchedule" && p.IsDeleted== false).ToListAsync();
            return sectionMaster;
        }

        public async Task<SectionMaster> GetEventSheduleById(int id)
        {
            //var a = await _dbContext.EventSchedules.Where(b => b.EventDate < DateTime.Now).ToListAsync();

            SectionMaster section = await _dbContext.SectionMasters.Where(m => m.SectionMasterId == id && m.IsDeleted == false).Include(k => k.EventSchedule).Include(z => z.StoredFiles).Include(q => q.Comments).FirstOrDefaultAsync();
             return section;
            //var a = (from a in _dbContext.EventSchedules
            //         join b in _dbContext.StoredFiles
            //         on a.SectionMasterId equals b.SectionMasterId 
            //         where a.EventDate equals DateTime.Now);
            //Console.WriteLine(a);
            //return await a;
        }
    }
}
