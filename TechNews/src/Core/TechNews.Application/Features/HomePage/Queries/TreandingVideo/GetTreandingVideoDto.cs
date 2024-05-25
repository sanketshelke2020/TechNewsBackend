using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Entities;

namespace TechNews.Application.Features.HomePage.Queries.TreandingVideo
{
    public class GetTreandingVideoDto
    {
        

        public int SectionMasterId { get; set; }
        public string Title { get; set; }
        public Byte[] Image { get; set; }
        public string ShortDescription { get; set; }
        public int TotalViews { get; set; }
    
        public string CategoryType { get; set; }
       
        
        public int YouTubeId { get; set; }
        public string LongDescription { get; set; }
    }
}
