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

        public async Task<IEnumerable<Database.Models.User>> GetUsersAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.User(), out string tableName, out string columns, out DynamicParameters parameters);
            var users = await _dbService.ExecuteQueryAsync<Database.Models.User>(Core.Database.Queries.Get(columns, tableName), parameters);

            return users;
        }
    }
}
