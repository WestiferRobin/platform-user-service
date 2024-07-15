using PlatformUserApi.Models;

namespace PlatformUserApi.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(Guid id);
        Task Add(User user);
        Task Update(User user);
        Task DeleteById(Guid id);
    }
}