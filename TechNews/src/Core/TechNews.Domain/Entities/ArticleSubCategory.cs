using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class ArticleSubCategory
    {
        public int ArticleSubCategoryId { get; set; }
        public string? ArticleSubCategoryName { get; set; }
        public int? ArticleCategoryId { get; set; }
        public virtual ArticleCategory ArticleCategory { get; set; }
        public virtual Article Articles { get; set; }

    }
}
