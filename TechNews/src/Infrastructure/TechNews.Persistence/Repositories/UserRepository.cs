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
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationDbContext dbContext, ILogger<User> logger) : base(dbContext, logger)
        {
        }

        public async Task<User> FindUserByEmail(string email)
        {
            return await _dbContext.Users.Include(x => x.UserRole).Where(a => a.Email == email).FirstOrDefaultAsync();
        }
    }
}
