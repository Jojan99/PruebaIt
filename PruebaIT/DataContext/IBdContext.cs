using System.Data.SqlClient;

namespace PruebaIT.DataContext
{
    public interface IBdContext
    {
        Task<List<T>> GetAsync<T>(string query, params SqlParameter[] parameters) where T : new();
        Task<T> GetSingleAsync<T>(string query, params SqlParameter[] parameters) where T : new();
        Task<bool> SentenciaAsync(string query, params SqlParameter[] parameters);
        Task SentenciaTaskAsync(string query, params SqlParameter[] parameters);
        Task<TValue> GetSingleValueAsync<TValue>(string query, params SqlParameter[] parameters);
        Task<int> InsertReturnIdAsync(string query, params SqlParameter[] parameters);
    }
}
