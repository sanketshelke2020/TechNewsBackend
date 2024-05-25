using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Contracts.Persistence;
using TechNews.Application.Features.Register.Command.AddUser;
using TechNews.Domain.Entities;

namespace TechNews.Persistence.Repositories
{
    public class RegisterRepository:BaseRepository<User>, IRegisterRepository
    {
        private readonly ILogger _logger;   
        public RegisterRepository(ApplicationDbContext dbContext, ILogger<User> logger) : base(dbContext, logger)
        {
        }

        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
        public async Task<List<Country>> GetAllCountry()
        {
            List<Country> country = _dbContext.Countries.ToList();
            return (country);
        }
        public async Task<List<State>> GetAllState(int CountryId)
        {
            List<State> states = _dbContext.States.Where(x => x.CountryId==CountryId).ToList();
            return (states);
        }
        public async Task<List<City>> GetAllCity(int StateId)
        {
            List<City> city = _dbContext.Cities.Where(x => x.StateId == StateId).ToList();
            return (city);
        }
       
         public async Task<bool> EmailsDoesNotExists(string email)
        {
            return await _dbContext.Users.Where(e => e.Email == email).CountAsync() == 0;
        }
        public async Task<List<UserRole>> GetAllUserRoles()
        {
            List<UserRole> userRoles =  _dbContext.UserRoles.ToList();
            return (userRoles);
        }
        public async Task<User> GetUserById(int id)
        {
            User user = await _dbContext.Users.Where(z => z.UserId == id).FirstOrDefaultAsync();
            return user;
        }




    }
}
