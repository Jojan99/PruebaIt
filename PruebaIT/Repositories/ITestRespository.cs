using PruebaIT.Models.Test;

namespace PruebaIT.Repositories
{
    public interface ITestRespository
    {
        Task<string> GetHelloWordAsync();
        Task<IEnumerable<TestModel>> GetTestAsync();
        Task CreateTestAsync(TestModel data);
        Task DeleteTestAsync(TestModel data);
        Task UpdateTestAsync(TestModel data);
    }
}
