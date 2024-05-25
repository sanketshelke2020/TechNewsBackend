using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Features.Youtube.Queries.GetAllYoutube;
using TechNews.Application.Features.Youtube.Queries.GetYoutubeById;
using TechNews.Domain.Entities;

namespace TechNews.Application.Profiles
{
    public class GetYoutubeByIdCustomMapper : ITypeConverter<SectionMaster, GetYoutubeByIdQueryDto>
    {
        private readonly IMapper _mapper;
        public GetYoutubeByIdCustomMapper(IMapper mapper)
        {
            _mapper = mapper;
        }
        public GetYoutubeByIdQueryDto Convert(SectionMaster source, GetYoutubeByIdQueryDto destination, ResolutionContext context)
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
            GetYoutubeByIdQueryDto dest = new GetYoutubeByIdQueryDto
            {


                Title = source.Title,
                Image = bytes,
                ShortDescription = source.ShortDescription,
                LongDescription = source.Youtube.LongDescription,
                TotalViews = (int)source.TotalViews,
                SectionMasterId = source.SectionMasterId,
                KeyWords = source.KeyWords,
                CategoryType = source.CategoryType,
                //StoredFiles = _mapper.Map<ICollection<GetYoutubeByIdStoredFileDto>>(source.StoredFiles),
                YoutubeVideoLink = source.Youtube.YoutubeVideoLink,
                Comments = _mapper.Map<ICollection<GetYoutubeByIdCommentDto>>(source.Comments),



            };
            return dest;
        }
}}
