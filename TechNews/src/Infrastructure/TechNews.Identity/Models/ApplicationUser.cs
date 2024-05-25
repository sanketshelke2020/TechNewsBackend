using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using TechNews.Domain.Entities;

namespace TechNews.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nationality { get; set; }
        public virtual int? CountryId { get; set; }
        
        public virtual int? StateId { get; set; }
      
        public virtual int? CityId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country? Country { get; set; }
        [ForeignKey("StateId")]
        public virtual State? State { get; set; }
        [ForeignKey("CityId")]
        public virtual City? City  { get; set; }
        public List<RefreshToken> RefreshTokens { get; set; }
    }
}
