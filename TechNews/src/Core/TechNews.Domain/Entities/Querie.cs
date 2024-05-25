﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class Querie
    {
        public int QuerieId { get; set; }
        public int UserId { get; set; }
        public string FullName { get; set; }
        public string JobDesignation { get; set; }
        public string CompanyName { get; set; }
        public string EmailAddress { get; set; }
        public string? MobileNumber { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public string CategoryType { get; set; }

    }
}