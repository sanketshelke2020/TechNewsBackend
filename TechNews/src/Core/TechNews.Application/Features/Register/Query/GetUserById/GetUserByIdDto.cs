using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechNews.Application.Features.Register.Query.GetUserById
{
    public class GetUserByIdDto
    {
        public int UserId { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CompanyName { get; set; }
        public string Nationality { get; set; }
        public Byte[] PasswordHash { get; set; }
        public Byte[] PasswordSalt { get; set; }
        public virtual int? CountryId { get; set; }
        
        public virtual int? StateId { get; set; }
        public virtual int? CityId { get; set; }
        public int UserRoleId { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
