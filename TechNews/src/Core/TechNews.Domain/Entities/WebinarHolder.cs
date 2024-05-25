﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class WebinarHolder
    {
        public int WebinarHolderId { get; set; }
        public string? Name { get; set; }
        public string? Designation { get; set; }
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }

        public int WebinarId { get; set; }
        public virtual Webinar Webinars { get; set; }
    }
}