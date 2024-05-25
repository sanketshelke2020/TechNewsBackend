using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Domain.Entities;

namespace TechNews.Persistence.Repositories
{
    public class ForgotPasswordRepository: BaseRepository<User>, IForgotPassword
    {
        public ForgotPasswordRepository(ApplicationDbContext dbContext, ILogger<User> logger) : base(dbContext, logger)
        {
        }

        public async Task<User> UserExists(string email)
        {
           var userExists = await _dbContext.Users.Where(u=>u.Email == email).FirstOrDefaultAsync();
            if (userExists != null)
            {
                return userExists;
            }
            else
            {
                throw new Exception("Email not found");
            }
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }
        public async Task<User> ResetUserPassword(ResetPassword resetPassword)
        {
            User userExists = await UserExists(resetPassword.Email);
            if(userExists != null)
            {
                CreatePasswordHash(resetPassword.NewPassword, out byte[] passwordHash, out byte[] passwordSalt);
                userExists.PasswordHash = passwordHash;
                userExists.PasswordSalt = passwordSalt;
                await _dbContext.SaveChangesAsync();
                return userExists;
            }
            else
            {
                throw new Exception("Cannot change");
            }
            
        }

        

        public async Task<User> ResetLoginPassword(ResetLoggedInPassword resetLoggedInPassword)
        {
            User userExists = await UserExists(resetLoggedInPassword.Email);
            if (userExists != null)
            {
                bool password = VerifyPasswordHash(resetLoggedInPassword.OldPassword, userExists.PasswordHash, userExists.PasswordSalt);
                if (password == true)
                {
                    CreatePasswordHash(resetLoggedInPassword.NewPassword, out byte[] passwordHash, out byte[] passwordSalt);
                    userExists.PasswordHash = passwordHash;
                    userExists.PasswordSalt = passwordSalt;
                    await _dbContext.SaveChangesAsync();
                }
                return userExists;
            }
            else
            {
                throw new Exception("Cannot change");
            }

        }

        public async Task<bool> OldPasswordDoesNotExists(OldPasswordExists oldPasswordExists)
        {
            User userExists = await UserExists(oldPasswordExists.Email);
            if (userExists != null)
            {
                bool oldPassword = VerifyPasswordHash(oldPasswordExists.OldPassword, userExists.PasswordHash, userExists.PasswordSalt);
                return oldPassword;
            }
            return false;
        }
    }
}
