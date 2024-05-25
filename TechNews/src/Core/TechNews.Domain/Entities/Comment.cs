using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Domain.Entities
{
    public class Comment
    {
        public int CommentId { get; set; }
        
        public string? CommentDescription { get; set; }
        public string? Email { get; set; }

        public int SectionMasterId { get; set; }
        public virtual SectionMaster SectionMaster { get; set; }
    }
}
