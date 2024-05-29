using PruebaIT.DataContext;
using PruebaIT.DataContext.Implementation;
using PruebaIT.Repositories;
using PruebaIT.Repositories.Implementation;
using PruebaIT.UseCases;
using PruebaIT.UseCases.Implementation;
using System.Data.SqlClient;

namespace PruebaIT
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            //conection
            services.AddScoped<IBdContext>(provider =>
            {
                var connectionString = configuration.GetConnectionString("DbConnectionString");
                var connection = new SqlConnection(connectionString);
                connection.Open();
                return new BdContext(connection);
            });

            //UseCase
            services.AddTransient<IGetTestUseCase, GetTestUseCase>();
            services.AddTransient<ICreateTestUseCase, CreateTestUseCase>();
            services.AddTransient<IDeleteTestUseCase, DeleteTestUseCase>();
            services.AddTransient<IUpdateTestUseCase, UpdateTestUseCase>();

            //USER
            services.AddTransient<ICreateUserUseCase, CreateUserUseCase>();
            services.AddTransient<IUpdateUserUseCase, UpdateUserUseCase>();
            services.AddTransient<IGetUserUseCase, GetUserUseCase>();
            services.AddTransient<IDeleteUserUseCase, DeleteUserUseCase>();




            //Repository
            services.AddTransient<ITestRespository, TestRespository>();
            services.AddTransient<IUserRepository, UserRepository>();

            return services;
        }
    }
}
