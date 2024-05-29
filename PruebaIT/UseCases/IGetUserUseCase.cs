using PruebaIT.Entities;

namespace PruebaIT.UseCases
{
    public interface IGetUserUseCase
    {
        Task<IEnumerable<User>> GetUserAsync();
    }
}
