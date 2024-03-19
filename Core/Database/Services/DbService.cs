using Dapper;
using Npgsql;
using SearchAndRescue.Core.Database.Contracts;
using System.Data;

namespace SearchAndRescue.Core.Database.Services
{
    public class DbService : IDbService
    {
        protected readonly string _connectionString;

        public DbService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public async Task<T> GetAsync<T>(string command, object parameters)
        {
            T result;
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                result = (await dbConnection.QueryAsync<T>(command, parameters).ConfigureAwait(false)).FirstOrDefault();
            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public async Task<IEnumerable<T>> GetAll<T>(string command, object parameters)
        {
            IEnumerable<T> result = null;
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                var test = await dbConnection.QueryAsync<T>(command, parameters);
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public async Task<int> SetData(string command, object parameters)
        {
            int result;
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                result = await dbConnection.ExecuteAsync(command, parameters);
            }
            catch (Exception)
            {
                throw;
            }

            return result;
        }

        public async Task<DynamicParameters> ExecuteProcedureAsync(string command, DynamicParameters parameters)
        {
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                await dbConnection.ExecuteAsync(command, parameters, commandType: CommandType.StoredProcedure);
            }
            catch (Exception)
            {
                throw;
            }
            return parameters;
        }

        public async Task<SqlMapper.GridReader> ExecuteMultipleQueriesAsync(string command, DynamicParameters parameters)
        {
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                return await dbConnection.QueryMultipleAsync(command, parameters);
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }

        public async Task<IEnumerable<T>> ExecuteFunctionAsync<T>(string command, object parameters)
        {
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                return await dbConnection.QueryAsync<T>(command, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
