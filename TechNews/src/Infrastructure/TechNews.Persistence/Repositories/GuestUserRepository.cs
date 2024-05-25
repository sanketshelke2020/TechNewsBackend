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
    public class GuestUserRepository : BaseRepository<GuestUser>, IGuestUserRepository
    {
        public GuestUserRepository(ApplicationDbContext dbContext, ILogger<GuestUser> logger) : base(dbContext, logger)
        {
        }

        public async Task<GuestUser> GetByEmailAsync(string email)
        {
            return await _dbContext.GuestUsers.FirstOrDefaultAsync(a => a.Email == email);
            
        }
    }
}
