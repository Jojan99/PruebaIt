using Microsoft.AspNetCore.Mvc;
using PruebaIT.Dtos.User;
using PruebaIT.Models;
using PruebaIT.UseCases;

namespace PruebaIT.Controllers
{


    [Route("api/updateUser")]
    [ApiController]
    public class UpdateUserController : BaseController
    {
        private readonly IUpdateUserUseCase _updateUserUseCase;

        public UpdateUserController(IUpdateUserUseCase updateUserUseCase)
        {
            _updateUserUseCase = updateUserUseCase;
        }

        [HttpPut]
        public async Task<ResponseWithElements> CreateUserAsync(UpdateUserDTO data)
        {
            return await ExecuteServiceAsync(async () => await _updateUserUseCase.UpdateUserAsync(data));

        }

    }
}
