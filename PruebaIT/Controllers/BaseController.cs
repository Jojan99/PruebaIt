using Microsoft.AspNetCore.Mvc;
using PruebaIT.Models;
using System.Net;

namespace PruebaIT.Controllers
{
    public class BaseController : Controller
    {
        protected async Task<ResponseWithElements> ExecuteServiceAsync<T>(Func<Task<T>> serviceMethodAsync)
        {
            var response = new ResponseWithElements();

            try
            {
                var result = await serviceMethodAsync();
                response.Success = true;
                response.Data = result!;
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Data = ex.Message;
            }

            return response;
        }

        protected async Task<ResponseWithElements> ExecuteServiceAsync(Func<Task> serviceMethodAsync)
        {
            var response = new ResponseWithElements();

            try
            {
                await serviceMethodAsync();
                response.Success = true;
                response.Data = "successful";
            }
            catch (Exception ex)
            {
                response.Success = false;
                response.Data = ex.Message;
            }

            return response;
        }
    }
}
