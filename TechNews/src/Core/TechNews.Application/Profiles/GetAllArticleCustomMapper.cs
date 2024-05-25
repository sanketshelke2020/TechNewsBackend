using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetAllArticle;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetAllArticleCustomMapper :ITypeConverter<SectionMaster,GetAllArticleQueryDto>
    {
        private readonly IMapper _mapper;
        public GetAllArticleCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }

         public GetAllArticleQueryDto Convert(SectionMaster source, GetAllArticleQueryDto destination, ResolutionContext context)
        {
            try
            {
                Byte[] bytes;
                string path = Path.Combine("Files/", source.Image);
                FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

                using (var ms = new MemoryStream())
                {
                    fileStream.CopyTo(ms)
    ;
                    bytes = ms.ToArray();
                }
                GetAllArticleQueryDto dest = new GetAllArticleQueryDto
                {


                    Title = source.Title,
                    Image = bytes,
                    ShortDescription = source.ShortDescription,
                    TotalViews = (int)source.TotalViews,
                    SectionMasterId = source.SectionMasterId,
                    KeyWords = source.KeyWords,
                    CategoryType = source.CategoryType,
                    ArticleId = source.Article.ArticleId,
                    LongDescription = source.Article.LongDescription,
                    CountryId = source.Article.Country.CountryId,
                    CountryName = source.Article.Country.CountryName,
                    ArticleCategoryId = (int)source.Article.ArticleCategoryId,
                    ArticleSubCategoryId = (int)source.Article.ArticleSubCategoryId,
                    
                    StoredFiles = _mapper.Map<ICollection<ArticleStoreFileDto>>(source.StoredFiles),
                    YoutubeVideoLink = source.Article.YoutubeVideoLink,
                };
                return dest;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
