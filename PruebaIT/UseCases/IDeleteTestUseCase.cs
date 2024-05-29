using PruebaIT.Dtos.Test;

namespace PruebaIT.UseCases
{
    public interface IDeleteTestUseCase
    {
        Task DeleteTestAsync(DeleteTestDTO data);
    }
}
