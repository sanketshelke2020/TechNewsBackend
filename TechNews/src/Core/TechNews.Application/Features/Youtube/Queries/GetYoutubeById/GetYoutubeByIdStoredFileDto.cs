using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Youtube.Queries.GetYoutubeById
{
    public class GetYoutubeByIdStoredFileDto
    {
        public int StoredFileId { get; set; }
        public string StoredFileName { get; set; }
        public Byte[] StoredFilePath { get; set; }
        public string FileType { get; set; }


        public int? SectionMasterId { get; set; }
    }
}
