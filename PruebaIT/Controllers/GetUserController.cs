using Microsoft.AspNetCore.Mvc;
using PruebaIT.Dtos.Test;
using PruebaIT.Models;
using PruebaIT.UseCases;

namespace PruebaIT.Controllers
{

    [Route("api/getUser")]
    [ApiController]
    public class GetUserController : BaseController
    {

        private readonly IGetUserUseCase _getUserUseCase;


        public GetUserController(IGetUserUseCase userUseCase)
        {
            _getUserUseCase = userUseCase;
        }

        [HttpGet]
        public async Task<ResponseWithElements> GetUserAsync()
        {
            return await ExecuteServiceAsync(async () => await _getUserUseCase.GetUserAsync());
        }

    }
}
