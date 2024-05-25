using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.Articles.Queries.GetArticleById
{
    public class GetArticleByIdQueryDto
    {
        public int ArticleId { get; set; }


        public int ArticleCategoryId { get; set; }
        public string ArticleCategoryName { get; set; }
        public int ArticleSubCategoryId { get; set; }
        public string ArticleSubCategoryName { get; set; }
        public string LongDescription { get; set; }

        public int SectionMasterId { get; set; }
        public string Title { get; set; }
        public Byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public int TotalViews { get; set; }
        public string KeyWords { get; set; }
        public string CategoryType { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public ICollection<GetArticleByIdStoredFileDto> StoredFiles { get; set; }
        public ICollection<GetArticleByIdCommentDto>? Comments { get; set; }
        public string? YoutubeVideoLink { get; set; }


    }
}
