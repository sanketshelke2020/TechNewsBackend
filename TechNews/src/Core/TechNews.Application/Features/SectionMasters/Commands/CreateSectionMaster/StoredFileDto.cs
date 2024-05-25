using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.SectionMasters.Commands.CreateSectionMaster
{
    public class StoredFileDto
    {
        public string? StoredFileName { get; set; }
        public string StoredFilePath { get; set; }
        public byte[]? File { get; set; }
        public string? FileType { get; set; }
    }
}
