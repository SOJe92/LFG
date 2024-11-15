using Dapper;
using SearchAndRescue.Admin.Contracts.Repositories;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;

namespace SearchAndRescue.Admin.Repositories
{
    public class Admin : IAdmin
    {
        private readonly IDbService _dbService;

        public Admin(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<Database.Models.User> GetUserAsync(Guid id)
        {
            string idCol = "id";
            DynamicParameters parameters = new();
            parameters.Add($"p{idCol}", id);
            PostgresDataAccess.BuildGetQuery<Database.Models.User>(out string tableName, out string columns);
            var user = await _dbService.ExecuteQueryFirstAsync<Database.Models.User>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return user;
        }

        public async Task<IEnumerable<Database.Models.User>> GetUsersAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.User(), out string tableName, out string columns, out DynamicParameters parameters);
            var users = await _dbService.ExecuteQueryAsync<Database.Models.User>(Core.Database.Queries.Get(columns, tableName), parameters);

            return users;
        }

        public async Task<bool> UpdateUserAsync(Database.Models.User user)
        {
            PostgresDataAccess.BuildUpdateQuery(user, out string tableName, out string columns);

            bool result = await _dbService.ExecuteQueryFirstAsync<bool>(Core.Database.Queries.UpdateById(columns, tableName, "id"), user);

            return result;
        }
    }
}
