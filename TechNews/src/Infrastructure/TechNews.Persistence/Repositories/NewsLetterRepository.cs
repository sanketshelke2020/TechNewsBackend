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
    public class NewsLetterRepository : BaseRepository<NewsLetter>, INewsLetterRepository

    {
        public NewsLetterRepository(ApplicationDbContext dbContext, ILogger<NewsLetter> logger) : base(dbContext, logger)
        {
        }

        public async Task<bool> NewsLetterEmailExist(string email)
        {
            var news = await _dbContext.NewsLetter.Where(z => z.Email == email).FirstOrDefaultAsync();
            if(news == null)
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
