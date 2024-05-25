using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Responses;

namespace TechNews.Application.Features.Register.Command.AddUser
{
    public class AddUserCommand : IRequest<Response<AddUserCommandDto>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? CompanyName { get; set; }
        public string Nationality { get; set; }
        public virtual int? CountryId { get; set; }
        public virtual int? StateId { get; set; }
        public virtual int? CityId { get; set; }
        public int UserRoleId { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
