using Microsoft.AspNetCore.Mvc;
using PruebaIT.Models;
using PruebaIT.UseCases;

namespace PruebaIT.Controllers
{
    public class GetTestController : BaseController
    {
        private readonly IGetTestUseCase _testUseCase;

        public GetTestController(IGetTestUseCase testUseCase)
        {
            _testUseCase = testUseCase;
        }

        [HttpGet]
        public async Task<ResponseWithElements> GetTestAsync()
        {
            return await ExecuteServiceAsync(async () => await _testUseCase.GetTestAsync());

        }
    }
}
