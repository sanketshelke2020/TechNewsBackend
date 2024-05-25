﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.LiveInterviews.Queries.GetListOfLiveInteriviews
{
    public class GetLiveInterviewDto
    {
        public int SectionMasterId { get; set; }
        public string Title { get; set; }
        public Byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public int TotalViews { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
