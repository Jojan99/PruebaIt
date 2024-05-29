using PruebaIT.Dtos.User;
using PruebaIT.Entities;
using PruebaIT.Models;
using PruebaIT.Repositories;

namespace PruebaIT.UseCases.Implementation
{
    public class CreateUserUseCase : ICreateUserUseCase
    {
        private readonly IUserRepository _userRepository;

        public CreateUserUseCase(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        //Metodo encargado de CrearUsuario
        public async Task CreateUserAsync(CreateUserDTO data)
        {
            DateTime date1 = data.DateA;
            DateTime date2 = data.Date;

            var result = DateTime.Compare(date1, date2);

            var dataUser = new User

            {
                Name = data.Name,
                Date = data.Date,
                Email = data.Email,
                Gender = data.Gender,
                Address = data.Address,
                Phone = data.Phone,
                DateA = data.DateA,
            };

            if (result >= 1  ) {
                //Armamos Modelo de los parametros a registrar

                await _userRepository.CreateUserAsync(dataUser);

            }

        }


    }
}
