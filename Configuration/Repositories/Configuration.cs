using Dapper;
using SearchAndRescue.Configuration.Database.Models;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using IConfiguration = SearchAndRescue.Configuration.Contracts.Repositories.IConfiguration;
namespace SearchAndRescue.Configuration.Repositories
{
    public class Configuration : IConfiguration
    {
        private readonly IDbService _dbService;

        public Configuration(IDbService dbService) => _dbService = dbService;

        public async Task<Permission> GetPermissionAsync(Permission permission)
        {
            string idCol = "id";
            PostgresDataAccess.BuildGetQuery(permission, out string tableName, out string columns, out DynamicParameters parameters, idCol);
            permission = await _dbService.ExecuteQueryFirstAsync<Database.Models.Permission>(Core.Database.Queries.GetById(columns, tableName, idCol), parameters);

            return permission;
        }

        public async Task<IEnumerable<Permission>> GetPermissionsAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Permission(), out string tableName, out string columns, out DynamicParameters parameters);
            var permissions = await _dbService.ExecuteQueryAsync<Permission>(Core.Database.Queries.Get(columns, tableName), parameters);

            return permissions;
        }
    }
}
