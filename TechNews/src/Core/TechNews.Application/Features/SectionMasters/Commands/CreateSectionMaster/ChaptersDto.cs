using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.SectionMasters.Commands.CreateSectionMaster
{
    public class ChaptersDto
    {
        public byte[]? AudioFile { get; set; }
        public string? Audio { get; set; }
        public string? ChapterTitle { get; set; }
        public int? ChapterNumber { get; set; }
        public string? ChapterDescription { get; set; }
    }
}
