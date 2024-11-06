using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Entity.Contracts.Repositories;
using SearchAndRescue.Helpers;

namespace SearchAndRescue.Entity.Repositories
{
    public class Entity : IEntity
    {
        private readonly IDbService _dbService;

        public Entity(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<int> Add(Database.Models.Entity entity)
        {
            PostgresDataAccess.BuildQuery(entity, out string tableName, out string columns, out string parameters, out DynamicParameters parametersModel);
            int result = await _dbService.SetData(Core.Database.Queries.Insert(columns, tableName, parameters), parametersModel);

            return result;
        }

        public async Task<bool> Delete(Guid id)
        {
            DynamicParameters? param = new DynamicParameters();
            param.Add("pid", id);
            PostgresDataAccess.BuildDeleteQuery(new Database.Models.Entity { Id = id }, out string tableName);
            int count = await _dbService.ExecuteFunctionAsync(Core.Database.Queries.DeleteById(tableName, "id"), param);
            return count > 0;
        }

        public async Task<Database.Models.Entity> Get(Guid id)
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.Entity(), out string tableName, out string columns, out DynamicParameters parameters, "id");
            IEnumerable<Database.Models.Entity>? entity = await _dbService.ExecuteQueryAsync<Database.Models.Entity>(Core.Database.Queries.Get(columns, tableName), parameters);

            return entity.FirstOrDefault();
        }

        public async Task<bool> Update(Database.Models.Entity entity)
        {
            PostgresDataAccess.BuildUpdateQuery(entity, out string tableName, out string columns);

            int result = await _dbService.SetData(Core.Database.Queries.UpdateById(columns, tableName, "id"), entity);

            return result > 0;
        }
    }
}
