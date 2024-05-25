using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class Article
    {
        public int ArticleId { get; set; }
        
        
        public int? ArticleCategoryId { get; set; }
        public int? ArticleSubCategoryId { get; set; }
        public string? LongDescription { get; set; }

        public int SectionMasterId { get; set; }
        public string? YoutubeVideoLink { get; set; }
        public virtual SectionMaster SectionMaster { get; set; }
        public int? CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual ArticleCategory ArticleCategory { get; set; }
        public virtual ArticleSubCategory ArticleSubCategory { get; set; }
        //public string? YoutubeVideoLink { get; set; }
    }
}
