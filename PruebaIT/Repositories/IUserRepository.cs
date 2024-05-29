using PruebaIT.Entities;

namespace PruebaIT.Repositories
{
    public interface IUserRepository
    {
        Task CreateUserAsync(User data);

        Task UpdateUserAsync(User data);

        Task<IEnumerable<User>> GetUserAsync();
        Task DeleteUserAsync(User data);
    }
}
