using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TechNews.Application.Features.Register.Command.AddUser;
using TechNews.Domain.Entities;

namespace TechNews.Application.Contracts.Persistence
{
    public interface IRegisterRepository : IAsyncRepository<User>
    {
        public void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt);
        Task<List<Country>> GetAllCountry();
        Task<List<State>> GetAllState(int CountryId);
         Task<List<City>> GetAllCity(int StateId);
        //Task<AddUserCommandDto> RegisterUserAsync(User request);
         Task<bool> EmailsDoesNotExists(string email);
        Task<List<UserRole>> GetAllUserRoles();
        Task<User> GetUserById(int id);
    }
}
