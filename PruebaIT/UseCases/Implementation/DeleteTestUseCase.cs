using PruebaIT.Dtos.Test;
using PruebaIT.Models.Test;
using PruebaIT.Repositories;

namespace PruebaIT.UseCases.Implementation
{
    public class DeleteTestUseCase : IDeleteTestUseCase
    {
        private readonly ITestRespository _testRespository;

        public DeleteTestUseCase(ITestRespository testRespository)
        {
            _testRespository = testRespository;
        }


        public async Task DeleteTestAsync(DeleteTestDTO data)
        {
            var deleteTest = new TestModel
            {
                Id = data.Id
            };

            await _testRespository.DeleteTestAsync(deleteTest);

        }
    }
}
