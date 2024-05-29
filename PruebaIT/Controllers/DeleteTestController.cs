using Microsoft.AspNetCore.Mvc;
using PruebaIT.Dtos.Test;
using PruebaIT.Models;
using PruebaIT.UseCases;

namespace PruebaIT.Controllers
{

    public class DeleteTestController : BaseController
    {

        private readonly IDeleteTestUseCase _deleteTestUseCase;


        public DeleteTestController(IDeleteTestUseCase deleteTestUseCase)
        {
            _deleteTestUseCase = deleteTestUseCase;
        }

        [HttpDelete]
        public async Task<ResponseWithElements> DeleteTestAsync(DeleteTestDTO data)
        {

            return await ExecuteServiceAsync(async () => await _deleteTestUseCase.DeleteTestAsync(data));

        }

    }
}
