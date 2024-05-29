using Microsoft.AspNetCore.Mvc;
using PruebaIT.Dtos.User;
using PruebaIT.Models;
using PruebaIT.UseCases;

namespace PruebaIT.Controllers
{

    [Route("api/createUser")]
    [ApiController]
    public class CreateUseController : BaseController
    {
        private readonly ICreateUserUseCase _createUserUseCase;

        public CreateUseController(ICreateUserUseCase createUserUseCase)
        {
            _createUserUseCase = createUserUseCase;
        }

        [HttpPost]
        public async Task<ResponseWithElements> CreateUserAsync(CreateUserDTO data)
        {

            return await ExecuteServiceAsync(async () => await _createUserUseCase.CreateUserAsync(data));
        }

    }
}
