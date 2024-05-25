using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryName { get; set; }

        public string ShortName { get; set; }
        public int PhoneCode { get; set; }

    }
}
