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
    public class ArticleRepository : BaseRepository<Article>, IArticleRepository
    {
        private readonly ILogger<ArticleRepository> _logger;
        public ArticleRepository(ApplicationDbContext dbContext, ILogger<Article> logger) : base(dbContext, logger)
        {
        }
        public async Task<List<SectionMaster>> GetAllArticle()
        {
            List<SectionMaster> articles = await _dbContext.SectionMasters.Include(q => q.Article)
                                                                           .Include(c => c.Article.Country)
                                                                           .Include(m => m.StoredFiles)
                                                                           .Where(p => p.CategoryType.Contains("Article") && p.IsDeleted == false).ToListAsync();
            //List<Article> articl = await _dbContext.Articles.Include(p => p.SectionMaster).Include(x => x.ArticleCategory).Include(x => x.ArticleSubCategory).ToListAsync();
            return articles;
        }
       

        public async Task<List<ArticleCategory>> GetAllArticleCategory()
        {
            List<ArticleCategory> articleCategories = await _dbContext.ArticleCategories.ToListAsync();
            return (articleCategories);
        }

        public async Task<List<ArticleSubCategory>> GetAllArticleSubCategory(int ArticleCategoryId)
        {
            List<ArticleSubCategory> articleSubCategories = await _dbContext.ArticleSubCategories.Where(x => x.ArticleCategoryId == ArticleCategoryId).ToListAsync();
            return articleSubCategories;
        }

        public async Task<SectionMaster> GetArticleById(int id)
        {
            SectionMaster sectionMaster = await _dbContext.SectionMasters.Include(q => q.Article).Where(q => q.SectionMasterId == id).Include(z => z.Article.ArticleCategory).Include(p => p.Article.ArticleSubCategory).Include(c => c.Article).Include(k => k.Article.Country).Include(q => q.Comments).Include(m => m.StoredFiles).FirstOrDefaultAsync();
            sectionMaster.TotalViews += 1;
            _dbContext.SaveChanges();
            return sectionMaster;
        }


    }
}
