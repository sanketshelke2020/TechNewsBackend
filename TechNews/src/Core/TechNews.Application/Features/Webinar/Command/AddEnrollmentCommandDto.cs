﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Webinar.Command
{
    public class AddEnrollmentCommandDto
    {
        public int UserId { get; set; }
        public int WebinarId { get; set; }
       // public Webinar Webinar { get; set; }

    }
}
