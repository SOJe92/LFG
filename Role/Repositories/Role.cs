using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using SearchAndRescue.Role.Contracts.Repositories;

namespace SearchAndRescue.Role.Repositories
{
    public class Role : IRole
    {
        private readonly IDbService _dbService;

        public Role(IDbService dbService) => _dbService = dbService;
        public async Task<Database.Models.Role> GetRoleAsync(Database.Models.Role role)
        {
            PostgresDataAccess.BuildGetQuery(role, out string tableName, out string columns, out DynamicParameters parameters, "id");
            role = await _dbService.ExecuteQueryFirstAsync<Database.Models.Role>(Core.Database.Queries.Get(columns, tableName), parameters);

            return role;
        }

        public async Task<IEnumerable<Database.Models.Role>> GetRolesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.Role(), out string tableName, out string columns, out DynamicParameters parameters);
            var roles = await _dbService.ExecuteQueryAsync<Database.Models.Role>(Core.Database.Queries.Get(columns, tableName), parameters);

            return roles;
        }
    }
}
