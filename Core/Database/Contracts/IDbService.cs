using Dapper;

namespace SearchAndRescue.Core.Database.Contracts
{
    public interface IDbService
    {
        Task<T> GetAsync<T>(string command, object parameters);
        Task<IEnumerable<T>> GetAll<T>(string command, object parameters);
        Task<int> SetData(string command, object parameters);
        Task<DynamicParameters> ExecuteProcedureAsync(string command, DynamicParameters parameters = null);
        Task<IEnumerable<T>> ExecuteFunctionAsync<T>(string command, object parameters = null);
    }
}
