using PruebaIT.Dtos.User;

namespace PruebaIT.UseCases
{
    public interface IDeleteUserUseCase 
    {
        Task DeleteUserAsync(DeleteUserDTO data);
    }
}
