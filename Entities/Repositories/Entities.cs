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
            var entities = await _dbService.ExecuteQueryAsync<Database.Models.Entities>(Queries.GetByUserId, param);
            return entities;
        }

        public async Task<IEnumerable<Database.Models.Entities>> Get()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.Entities(), out string tableName, out string columns, out DynamicParameters parameters);
            var entities = await _dbService.ExecuteQueryAsync<Database.Models.Entities>(Core.Database.Queries.Get(columns, tableName), parameters);

            return entities;
        }
    }
}
