﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Articles.Queries.GetAllArticle
{
    public class ArticleStoreFileDto
    {
        public int StoredFileId { get; set; }
        public string StoredFileName { get; set; }
        public string StoredFilePath { get; set; }
        public string FileType { get; set; }
    }
}
