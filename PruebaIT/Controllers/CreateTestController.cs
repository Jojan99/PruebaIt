using Microsoft.AspNetCore.Mvc;
using PruebaIT.Dtos.Test;
using PruebaIT.Models;
using PruebaIT.UseCases;

namespace PruebaIT.Controllers
{
    public class CreateTestController : BaseController
    {
        private readonly ICreateTestUseCase _createTestUseCase;

        public CreateTestController(ICreateTestUseCase createTestUseCase)
        {
            _createTestUseCase = createTestUseCase;
        }

        [HttpPost]
        public async Task<ResponseWithElements> CreateTestAsync(CreateTestDTO data)
        {
            return await ExecuteServiceAsync(async () => await _createTestUseCase.CreateTestAsync(data));
        }

    }
}
