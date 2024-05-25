using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class StoredFile
    {
        public int StoredFileId { get; set; }
        public string StoredFileName { get; set; }
        public string StoredFilePath { get; set; }  
        public string FileType { get; set; }
        

        public int? SectionMasterId { get; set; }
        public SectionMaster? SectionMaster { get; set; }
    }
}
