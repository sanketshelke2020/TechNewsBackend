using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Magazines.Query.GetMagazineById
{
    public class GetMagazineByIdDto
    {
        public int SectionMasterId { get; set; }
        public string Title { get; set; }
        public Byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public int TotalViews { get; set; }
        public string KeyWords { get; set; }
        public string CategoryType { get; set; }
        public int MagazineId { get; set; }
        public int? NumberOfPages { get; set; }
        public string? LongDescription { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<GetMagazineByIdStoreFileDto>? StoredFiles { get; set; }
        public ICollection<GetMagzineByIdCommentDto> Comments { get; set; }
    }
}
