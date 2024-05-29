using PruebaIT.Models.Test;

namespace PruebaIT.UseCases
{
    public interface IGetTestUseCase
    {
        Task<IEnumerable<TestModel>> GetTestAsync();

    }
}
