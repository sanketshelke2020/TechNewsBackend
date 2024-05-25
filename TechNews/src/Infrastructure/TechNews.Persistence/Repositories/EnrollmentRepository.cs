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
    public class EnrollmentRepository : BaseRepository<Enrollment>, IEnrollmentRepository
    {
        private readonly ILogger<EnrollmentRepository> _logger;

        public EnrollmentRepository(ApplicationDbContext dbContext, ILogger<Enrollment> logger) : base(dbContext, logger)
        {

        }
            
        public async Task<bool> EnrollmentDone(int userId, int webinarId)
        {
            return await _dbContext.Enrollments.Where(e => e.UserId == userId && e.WebinarId == webinarId).CountAsync() == 1;
        }

        public async Task<List<Enrollment>> GetAllEnrolledUser(int WebinarId)
        {
            return await _dbContext.Enrollments
                .Where(x => x.WebinarId == WebinarId)
                .ToListAsync();
        }

        public async Task<Enrollment> GetEnrollmentByUserAndWebinarId(int userId, int webinarId)
        {
            return await _dbContext.Enrollments
                .FirstOrDefaultAsync(x => x.UserId == userId && x.WebinarId == webinarId);
        }
    }
}
