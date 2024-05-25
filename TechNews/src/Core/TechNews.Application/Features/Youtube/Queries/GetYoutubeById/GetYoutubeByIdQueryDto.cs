using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Articles.Queries.GetArticleById;
using TechNews.Application.Features.Youtube.Queries.GetAllYoutube;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.Youtube.Queries.GetYoutubeById
{
    public class GetYoutubeByIdQueryDto
    {
        public int YouTubeId { get; set; }
        public string ShortDescription { get; set; }

        public string LongDescription { get; set; }
        public string YoutubeVideoLink { get; set; }
        public int SectionMasterId { get; set; }
        public virtual SectionMaster SectionMaster { get; set; }
        public string Title { get; set; }
        public Byte[] Image { get; set; }

        public int TotalViews { get; set; }
        //public ICollection<GetYoutubeByIdStoredFileDto> StoredFiles { get; set; }
        public ICollection<GetYoutubeByIdCommentDto>? Comments { get; set; }

        public string KeyWords { get; set; }
        public string CategoryType { get; set; }
    }
}
