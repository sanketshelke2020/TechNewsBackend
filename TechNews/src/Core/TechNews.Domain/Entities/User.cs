using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Domain.Common;

namespace TechNews.Domain.Entities
{
    public class User : AuditableEntity
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public Byte[] PasswordHash { get; set; }
        public Byte[] PasswordSalt { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ?CompanyName { get; set; }
        public string Nationality { get; set; }

        public string? PhoneNumber { get; set; }
        public virtual int? CountryId { get; set; }

        public virtual int? StateId { get; set; }

        public virtual int? CityId { get; set; }
        [ForeignKey("CountryId")]
        public virtual Country? Country { get; set; }
        [ForeignKey("StateId")]
        public virtual State? State { get; set; }
        [ForeignKey("CityId")]
        public virtual City? City { get; set; }
        public int UserRoleId { get; set; }

        [ForeignKey("UserRoleId")]
        public virtual UserRole UserRole { get; set; }
        

    }
}
