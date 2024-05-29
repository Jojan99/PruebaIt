using PruebaIT.Dtos.User;
using PruebaIT.Entities;
using PruebaIT.Repositories;

namespace PruebaIT.UseCases.Implementation
{
    public class DeleteUserUseCase : IDeleteUserUseCase
    {

        private readonly IUserRepository _userRepository;

        public DeleteUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //Metodo encargado de Eliminar Usuario

        public async Task DeleteUserAsync(DeleteUserDTO data)
        {
            //Armamos Modelo de los parametros a registrar
            var dataUser = new User

            {
                Id = data.Id,
            };

            await _userRepository.DeleteUserAsync(dataUser);

        }
    }
}
