using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class ArticleCategory
    {
        public int ArticleCategoryId { get; set; }
        public string? ArticleCategoryName { get; set; }
        public virtual Article Articles { get; set; }
       
    }
}
