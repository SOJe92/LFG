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

        public async Task<int> SetData(string command, DynamicParameters parameters)
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

        public async Task<int> ExecuteFunctionAsync(string command, object parameters)
        {
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                var result = await dbConnection.ExecuteAsync(command, parameters);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<T>> ExecuteQueryAsync<T>(string command, object parameters)
        {
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                var result = await dbConnection.QueryAsync<T>(command, parameters);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> ExecuteQueryFirstAsync<T>(string command, DynamicParameters parameters)
        {
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                var result = await dbConnection.QueryFirstAsync<T>(command, parameters);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<T> ExecuteQueryFirstAsync<T>(string command, object parameters)
        {
            try
            {
                using IDbConnection dbConnection = new NpgsqlConnection(_connectionString);
                var result = await dbConnection.QueryFirstAsync<T>(command, parameters);
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
