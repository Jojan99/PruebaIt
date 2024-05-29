using PruebaIT.DataContext;
using PruebaIT.Models.Test;
using PruebaIT.SqlStatements;
using System.Data.SqlClient;

namespace PruebaIT.Repositories.Implementation
{
    public class TestRespository : ITestRespository
    {
        private readonly IBdContext _dbContext;

        public TestRespository(IBdContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<string> GetHelloWordAsync()
        {
            return await Task.FromResult("Hello");

        }

        public async Task<IEnumerable<TestModel>> GetTestAsync()
        {
            var sqlStatement = SqlStatement.GetTest;

            SqlParameter[] parameters = new SqlParameter[]
            {
            };

            return await _dbContext.GetAsync<TestModel>(sqlStatement, parameters);
        }

        public async Task CreateTestAsync(TestModel data)
        {
            var sqlStatement = SqlStatement.CreateTest;

            SqlParameter[] parameters = new SqlParameter[] {
                new("@Name", data.Name),
            };

            await _dbContext.SentenciaTaskAsync(sqlStatement, parameters);
        }

        public async Task DeleteTestAsync(TestModel data)
        {
            var sqlStatement = SqlStatement.DeleteTest;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@Id", data.Id),
            };

            await _dbContext.SentenciaTaskAsync(sqlStatement, parameters);
        }


        public async Task UpdateTestAsync(TestModel data)
        {
            var sqlStatement = SqlStatement.UpdateTest;

            SqlParameter[] parameters = new SqlParameter[]
            {
                new("@Id", data.Id),
                new("@Name", data.Name),
            };

            await _dbContext.SentenciaTaskAsync(sqlStatement, parameters);

        }

    }
}
