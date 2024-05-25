using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IArticleRepository : IAsyncRepository<Article>
    {
        Task<List<SectionMaster>> GetAllArticle();
        Task<List<ArticleCategory>> GetAllArticleCategory();
        Task<List<ArticleSubCategory>> GetAllArticleSubCategory(int ArticleCategoryId);
       Task<SectionMaster> GetArticleById(int id);

    }
}
