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

            ValidarteModelUser(data);

            //Armamos Modelo de los parametros a registrar

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

                await _userRepository.CreateUserAsync(dataUser);

            }
            else
            {
                throw new ArgumentException("La fecha de nacimiento debe ser menor a la fecha actual");
            }

        }

        private void ValidarteModelUser(CreateUserDTO data)
        {
            if (data.Name == string.Empty)
            {
                throw new ArgumentException("el nombre no debe ser vacio");
            }
            else if (data.Email == string.Empty)
            {
                throw new ArgumentException("el Email no debe ser vacio");
            }
            else if (data.Gender < 0)
            {
                throw new ArgumentException("el Genero no debe ser vacio");
            }
            else if (data.Address == string.Empty)
            {
                throw new ArgumentException("la direccion no debe ser vacia");
            }
            else if (data.Phone <  0)
            {
                throw new ArgumentException("el telefono no debe ser vacia");
            }
        }
    }
}
