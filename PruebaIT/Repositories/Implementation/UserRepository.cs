using PruebaIT.DataContext;
using PruebaIT.Entities;
using PruebaIT.SqlStatements;
using System.Data.SqlClient;

namespace PruebaIT.Repositories.Implementation
{
    public class UserRepository : IUserRepository
    {

        private readonly IBdContext _dbContext;

        public UserRepository(IBdContext dbContext)
        {
            _dbContext = dbContext;
        }
        //Metodo Encargado de crear Usuario

        public async Task CreateUserAsync(User data)
        {
            var SqlStatements = SqlStatement.CreateUser;


            SqlParameter[] parameters = new SqlParameter[]

           {
                new("@Name",data.Name),
                new("@Date",data.Date),
                new("@Email",data.Email),
                new("@Gender",data.Gender),
                new("@Address",data.Address),
                new("@Phone",data.Phone),
                new("@DateA",data.DateA),

           };

            await _dbContext.SentenciaTaskAsync(SqlStatements, parameters);

        }

        //Metodo Encargado de actualizar Usuario

        public async Task UpdateUserAsync(User data)
        {
            var SqlStatements = SqlStatement.UpdateUser;


            SqlParameter[] parameters = new SqlParameter[]

           {
                new("@Id",data.Id),
                new("@Name",data.Name),
                new("@Date",data.Date),
                new("@Email",data.Email),
                new("@Gender",data.Gender),
                new("@Address",data.Address),
                new("@Phone",data.Phone),
                new("@DateA",data.DateA),

           };

            await _dbContext.SentenciaTaskAsync(SqlStatements, parameters);

        }
        //Metodo Encargado de listar Usuario
        public async Task<IEnumerable<User>> GetUserAsync()
        {
            var SqlStatements = SqlStatement.GetUser;


            SqlParameter[] parameters = new SqlParameter[]

           {
             
           };

          return  await _dbContext.GetAsync<User>(SqlStatements, parameters);

        }
        //Metodo Encargado de eliminar Usuario

        public async Task DeleteUserAsync(User data)
        {
            var SqlStatements = SqlStatement.DeleteUser;


            SqlParameter[] parameters = new SqlParameter[]

           {
                new("@Id",data.Id),

           };

            await _dbContext.SentenciaTaskAsync(SqlStatements, parameters);

        }

    }
}
