using PruebaIT.Dtos.Test;
using PruebaIT.Models.Test;
using PruebaIT.Repositories;

namespace PruebaIT.UseCases.Implementation
{
    public class CreateTestUseCase : ICreateTestUseCase
    {

        private readonly ITestRespository _testRespository;


        public CreateTestUseCase(ITestRespository testRespository)
        {
            _testRespository = testRespository;
        }


        public async Task CreateTestAsync(CreateTestDTO data)
        {

            var createTest = new TestModel
            {
                Name = data.Name
            };

            await _testRespository.CreateTestAsync(createTest);
        }
    }
}
