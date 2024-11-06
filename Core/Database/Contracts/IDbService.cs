using Dapper;

namespace SearchAndRescue.Core.Database.Contracts
{
    public interface IDbService
    {
        Task<T> GetAsync<T>(string command, object parameters);
        Task<IEnumerable<T>> GetAll<T>(string command, object parameters);
        Task<int> SetData(string command, object parameters);
        Task<int> SetData(string command, DynamicParameters parameters = null);
        Task<DynamicParameters> ExecuteProcedureAsync(string command, DynamicParameters parameters = null);
        Task<int> ExecuteFunctionAsync(string command, object parameters = null);
        Task<IEnumerable<T>> ExecuteQueryAsync<T>(string command, object parameters);

        Task<T> ExecuteQueryFirstAsync<T>(string command, DynamicParameters parameters);
    }
}
