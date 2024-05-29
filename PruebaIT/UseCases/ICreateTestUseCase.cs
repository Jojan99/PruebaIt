using PruebaIT.Dtos.Test;

namespace PruebaIT.UseCases
{
    public interface ICreateTestUseCase
    {
        Task CreateTestAsync(CreateTestDTO data);
    }
}
