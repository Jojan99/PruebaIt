using PruebaIT.Entities;
using PruebaIT.Repositories;

namespace PruebaIT.UseCases.Implementation
{
    public class GetUserUseCase : IGetUserUseCase
    {

        private readonly IUserRepository _userRepository;


        public GetUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        //Metodo encargado de Listar Usuario

        public async Task<IEnumerable<User>> GetUserAsync()
        {
          return  await _userRepository.GetUserAsync();
        }

    }
}
