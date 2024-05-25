using System.ComponentModel.DataAnnotations;

namespace TechNews.Application.Models.Authentication
{
    public class RegistrationRequest
    {
        [Required] 
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MinLength(6)]
        public string UserName { get; set; }

        [Required]
        [MinLength(6)]
        public string Password { get; set; }
        public string Nationality { get; set; }

        public int CountryId { get; set; }

        public int StateId { get; set; }

        public int CityId { get; set; }
    }
}
