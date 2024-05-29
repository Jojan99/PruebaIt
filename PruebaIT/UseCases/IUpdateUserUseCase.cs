using PruebaIT.Dtos.User;

namespace PruebaIT.UseCases
{
    public interface IUpdateUserUseCase
    {
        Task UpdateUserAsync(UpdateUserDTO data);
    }
}
