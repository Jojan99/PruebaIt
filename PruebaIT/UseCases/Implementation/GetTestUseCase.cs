using PruebaIT.Models.Test;
using PruebaIT.Repositories;

namespace PruebaIT.UseCases.Implementation
{
    public class GetTestUseCase : IGetTestUseCase
    {

        private readonly ITestRespository _testRepository;


        public GetTestUseCase(ITestRespository testRespository)
        {
            _testRepository = testRespository;
        }

        public async Task<IEnumerable<TestModel>> GetTestAsync()
        {
            return await _testRepository.GetTestAsync();
        }
    }
}
