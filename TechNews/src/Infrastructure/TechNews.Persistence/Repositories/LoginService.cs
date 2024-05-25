using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Models.Authentication;
using TechNews.Domain.Entities;

namespace TechNews.Persistence.Repositories
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        private readonly ILogger<LoginService> _logger;

        public LoginService(IUserRepository userRepository, IConfiguration configuration, ILogger<LoginService> logger)
        {
            _userRepository = userRepository;
            _configuration = configuration;
            _logger = logger;
        }
        public async Task<AuthenticationResponse> Login(string email, string password)
        {
            User user = await _userRepository.FindUserByEmail(email)
;
            if (user == null)
            {

                throw new Exception("Faild to find user with these credentials");
            }
            else
            {
                bool isAuthenticated = VerifyPasswordHash(password, user.PasswordHash, user.PasswordSalt);
                if (isAuthenticated)
                {
                    string name = $"{user.FirstName} {user.LastName}";
                    string token = GenerateToken(user.UserId, user.Email, user.UserRole.RoleName, name);
                    return new AuthenticationResponse() { IsAuthenticated = true, Token = token, Role = user.UserRole.RoleName, Message = null, Id = user.UserId.ToString(), Email = user.Email };
                }
                else
                {
                    return null;
                }
            }
        }
        //Verify Password with Existing Hashed Password
        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        public string GenerateToken(int id, string email, string role, string name)
        {
            var payload = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Jti,id.ToString()),
                new Claim(JwtRegisteredClaimNames.Email,email),
                new Claim(JwtRegisteredClaimNames.GivenName,name),
                new Claim(ClaimTypes.Role,role)
            };

            string JwtSecret = _configuration.GetValue<string>("JwtSettings:Key");
            string JwtIssuer = _configuration.GetValue<string>("JwtSettings:Issuer");
            var JwtAudiance = _configuration.GetValue<string>("JwtSettings:Audience");
            var JwtValidity = _configuration.GetValue<string>("JwtSettings:DurationInMinutes");

            var symmetricKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtSecret));

            var jwtToken = new JwtSecurityToken(
                issuer: JwtIssuer,
                audience: JwtAudiance,
                claims: payload,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(JwtValidity)),
                signingCredentials: new SigningCredentials(symmetricKey, SecurityAlgorithms.HmacSha256)
            );
            var jwtSecurityTokenHandler = new JwtSecurityTokenHandler().WriteToken(jwtToken);
            return jwtSecurityTokenHandler;
        }


    }
}
