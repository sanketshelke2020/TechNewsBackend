using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.CaseStudies.Queries.GetCaseStudiesById
{
    public class GetCaseStudiesByIdStoredFileDto
    {
        public int StoredFileId { get; set; }
        public string StoredFileName { get; set; }
        public Byte[] StoredFilePath { get; set; }
        public string FileType { get; set; }


      
    }
}
