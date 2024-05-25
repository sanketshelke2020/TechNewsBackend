using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetArticleByIdCustomMapper : ITypeConverter<SectionMaster, GetArticleByIdQueryDto>
    {
        private readonly IMapper _mapper;
        public GetArticleByIdCustomMapper(IMapper mapper)
        {
            _mapper=mapper;
        }
        public GetArticleByIdQueryDto Convert(SectionMaster source, GetArticleByIdQueryDto destination, ResolutionContext context)
        {
            Byte[] bytes;
            Byte[] bytesvideo;
            string path = Path.Combine("Files/", source.Image);
            FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);

            using (var ms = new MemoryStream())
            {
                fileStream.CopyTo(ms)
;
                bytes = ms.ToArray();
            }

            List<GetArticleByIdStoredFileDto> mvp = new List<GetArticleByIdStoredFileDto>();
            if(source.StoredFiles == null)
            {
                foreach (var item in source.StoredFiles)
                {

                    string path2 = Path.Combine("Files/", item.StoredFilePath);
                    FileStream fileStream2 = new FileStream(path2, FileMode.Open, FileAccess.Read);

                    using (var ms = new MemoryStream())
                    {
                        fileStream2.CopyTo(ms)

        ;
                        bytesvideo = ms.ToArray();
                        Console.WriteLine(bytesvideo);
                    }
                    GetArticleByIdStoredFileDto sf = new GetArticleByIdStoredFileDto();
                    sf.StoredFileId = item.StoredFileId;
                    sf.StoredFileName = item.StoredFileName;
                    sf.StoredFilePath = bytesvideo;
                    sf.FileType = item.FileType;
                    mvp.Add(sf);
                }
            }
            
            GetArticleByIdQueryDto dest = new GetArticleByIdQueryDto
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
                ArticleCategoryId = source.Article.ArticleCategory.ArticleCategoryId,
                ArticleSubCategoryId = source.Article.ArticleSubCategory.ArticleSubCategoryId,
                ArticleCategoryName = source.Article.ArticleCategory.ArticleCategoryName,
                ArticleSubCategoryName = source.Article.ArticleSubCategory.ArticleSubCategoryName,
                YoutubeVideoLink = source.Article.YoutubeVideoLink,
                StoredFiles = mvp,
                Comments = _mapper.Map<ICollection<GetArticleByIdCommentDto>>(source.Comments),
            };
            return dest;
        }
    }
}
