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
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext dbContext, ILogger<Comment> logger) : base(dbContext, logger)
        {
        }
    }
}
