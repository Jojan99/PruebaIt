using Microsoft.AspNetCore.Mvc;
using PruebaIT.Dtos.Test;
using PruebaIT.Models;
using PruebaIT.UseCases;

namespace PruebaIT.Controllers
{
    public class UpdateTestController : BaseController
    {

        private readonly IUpdateTestUseCase _updateTestUseCase;

        public UpdateTestController(IUpdateTestUseCase updateTestUseCase)
        {
            _updateTestUseCase = updateTestUseCase;
        }

        [HttpPut]
        public async Task<ResponseWithElements> UpdateTestAsync(UpdateTestDTO data)
        {
            return await ExecuteServiceAsync(async () => await _updateTestUseCase.UpdateTestAsync(data));

        }

    }
}
