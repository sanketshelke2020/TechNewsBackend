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
    public class StoredFileRepository : BaseRepository<StoredFile>, IStoredFileRepository
    {
        public StoredFileRepository(ApplicationDbContext dbContext, ILogger<StoredFile> logger) : base(dbContext, logger)
        {
        }

        public bool RemoveStoredFileById(int id)
        {
            var fileToDelete = _dbContext.StoredFiles.FirstOrDefaultAsync(x => x.StoredFileId == id).Result;
            _dbContext.StoredFiles.Remove(fileToDelete);
            if (_dbContext.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }
    }
}
