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

        public async Task<IEnumerable<Database.Models.Entities>> Get(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("puserid", id);
            PostgresDataAccess.BuildQuery<Database.Models.Entities>(out _, out string columns);
            var entities = await _dbService.ExecuteQueryAsync<Database.Models.Entities>(Queries.GetByUserId(columns), param);
            return entities;
        }

        public async Task<IEnumerable<Database.Models.Entities>> Get()
        {
            PostgresDataAccess.BuildQuery<Database.Models.Entities>(out _, out string columns);
            var entities = await _dbService.ExecuteQueryAsync<Database.Models.Entities>(Queries.Get(columns));
            return entities;
        }
    }
}
