using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Models.Mail;
using TechNews.Domain.Entities;

namespace TechNews.Persistence.Repositories
{
    public class WebinarRepository : BaseRepository<WebinarRepository>, IWebinarRepository
    {
        private readonly ILogger<WebinarRepository> _logger;

        public WebinarRepository(ApplicationDbContext dbContext, ILogger<WebinarRepository> logger) : base(dbContext, logger)
        {
        }

        

        public async Task<List<SectionMaster>> GetAllWebinar()
        {
            List<SectionMaster> sectionMasters = await _dbContext.SectionMasters.Include(w=>w.Webinar).Where(t => t.CategoryType == "Webinar" && t.IsDeleted == false).ToListAsync();
            return sectionMasters;
        }

        public async Task<SectionMaster> GetWebinarById(int id)
        {
            SectionMaster sectionMaster = await _dbContext.SectionMasters.Include(c => c.Webinar).Where(q => q.SectionMasterId == id).Include(q => q.Comments).Include(q => q.Webinar.Enrollments).Include(q => q.Webinar.WebinarHolders).FirstOrDefaultAsync();
            sectionMaster.TotalViews += 1;
            _dbContext.SaveChanges();
            return sectionMaster;
        }
    }
}
