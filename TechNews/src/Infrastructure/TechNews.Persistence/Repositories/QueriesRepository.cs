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
    public class QueriesRepository : BaseRepository<Querie>, IQueriesrespository
    {
        private readonly ILogger _logger;

        public QueriesRepository(ApplicationDbContext dbContext, ILogger<Querie> logger) : base(dbContext, logger)
        {
        }
        public async Task<Querie>  GetUserQueryByid(int id)
        {
            return _dbContext.Queries.Where(a => a.QuerieId == id).Include(z => z.Country).FirstOrDefault();
        }
    }

}
