using Microsoft.AspNetCore.Mvc;
using PruebaIT.Dtos.User;
using PruebaIT.Models;
using PruebaIT.UseCases;
using PruebaIT.UseCases.Implementation;

namespace PruebaIT.Controllers
{
    [Route("api/deleteUser")]
    [ApiController]
    public class DeleteUserController : BaseController
    {

        private readonly IDeleteUserUseCase _deleteUserUseCase;

        public DeleteUserController(IDeleteUserUseCase deleteUserUseCase)
        {
            _deleteUserUseCase = deleteUserUseCase;
        }

        [HttpDelete]
        public async Task<ResponseWithElements> CreateUserAsync(DeleteUserDTO data)
        {
            return await ExecuteServiceAsync(async () => await _deleteUserUseCase.DeleteUserAsync(data));

        }
    }
}
