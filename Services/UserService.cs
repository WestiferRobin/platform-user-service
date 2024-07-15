using PlatformUserApi.Models;
using PlatformUserApi.Repositories;

namespace PlatformUserApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;

        public UserService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await repository.GetAll();
        }

        public async Task<User> GetUser(Guid id)
        {
            return await repository.GetById(id);
        }
    }
}