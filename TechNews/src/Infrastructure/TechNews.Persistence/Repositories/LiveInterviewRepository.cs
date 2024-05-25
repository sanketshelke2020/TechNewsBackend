using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Exceptions;
using TechNews.Domain.Entities;

namespace TechNews.Persistence.Repositories
{
    public class LiveInterviewRepository : BaseRepository<LiveInterview>, ILiveInterviewRepository
    {
        public LiveInterviewRepository(ApplicationDbContext dbContext, ILogger<LiveInterview> logger) : base(dbContext, logger)
        {
        }

        public async Task<SectionMaster> GetLiveInterviewById(int sectionMasterId)
        {
            var result = await _dbContext.SectionMasters
                .Include(x => x.LiveInterview)
                .Include(x=>x.Comments)
                .FirstOrDefaultAsync(x => x.SectionMasterId == sectionMasterId);
            if (result == null)
            {
                throw new NotFoundException(nameof(SectionMaster), sectionMasterId);
            }
            result.TotalViews += 1;
            _dbContext.SaveChanges();
            return result;
        }
    }
}
