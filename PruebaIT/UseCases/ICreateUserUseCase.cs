using PruebaIT.Dtos.User;

namespace PruebaIT.UseCases
{
    public interface ICreateUserUseCase
    {
        Task CreateUserAsync(CreateUserDTO data);
    }
}
