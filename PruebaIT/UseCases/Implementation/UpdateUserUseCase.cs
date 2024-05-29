using PruebaIT.Dtos.User;
using PruebaIT.Entities;
using PruebaIT.Repositories;

namespace PruebaIT.UseCases.Implementation
{
    public class UpdateUserUseCase : IUpdateUserUseCase
    {

        private readonly IUserRepository _userRepository; 

        public UpdateUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //Metodo encargado de Actualizar Usuario
        public async Task UpdateUserAsync(UpdateUserDTO data)
        {
            var dataUser = new User

            {
                Id = data.Id,
                Name = data.Name,
                Date = data.Date,
                Email = data.Email,
                Gender = data.Gender,
                Address = data.Address,
                Phone = data.Phone,
                DateA = data.DateA,
            };

         await  _userRepository.UpdateUserAsync(dataUser);
        }
    }
}
