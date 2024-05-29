using PruebaIT.Dtos.Test;

namespace PruebaIT.UseCases
{
    public interface IUpdateTestUseCase
    {
        Task UpdateTestAsync(UpdateTestDTO data);
    }
}
