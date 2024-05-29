using Microsoft.AspNetCore.DataProtection.Repositories;
using PruebaIT.Dtos.Test;
using PruebaIT.Models.Test;
using PruebaIT.Repositories;

namespace PruebaIT.UseCases.Implementation
{
    public class UpdateTestUseCase : IUpdateTestUseCase
    {
        private readonly ITestRespository _testRespository;

        public UpdateTestUseCase(ITestRespository testRespository)
        {
            _testRespository = testRespository;
        }

        public async Task UpdateTestAsync(UpdateTestDTO data)
        {
            var updateModel = new TestModel
            {
                Id = data.Id,
                Name = data.Name
            };

            await _testRespository.UpdateTestAsync(updateModel);
        }

    }
}
