using AutoMapper;
using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Entities.Contracts.Repositories;
using SearchAndRescue.Entities.Database;
using SearchAndRescue.Helpers;

namespace SearchAndRescue.Entities.Repositories
{
    public class Entities : IEntities
    {
        private readonly IDbService _dbService;

        public Entities(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<IEnumerable<Models.Entity>> Get(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("puserid", id);
            PostgresDataAccess.BuildQuery<Models.Entity>(out _, out string columns);
            var entities = await _dbService.ExecuteQueryAsync<Models.Entity>(Queries.GetAll(columns), param);
            return entities;
        }

        public async Task<IEnumerable<Models.Entity>> GetAll()
        {
            PostgresDataAccess.BuildQuery<Models.Entity>(out _, out string columns);
            var entities = await _dbService.ExecuteQueryAsync<Models.Entity>(Queries.GetAll(columns));
            return entities;
        }
    }
}
