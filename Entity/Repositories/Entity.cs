using AutoMapper;
using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Entity.Contracts.Repositories;
using SearchAndRescue.Entity.Database;
using SearchAndRescue.Helpers;
using System.Data;

namespace SearchAndRescue.Entity.Repositories
{
    public class Entity : IEntity
    {
        private readonly IMapper _mapper;
        private readonly IDbService _dbService;

        public Entity(IMapper mapper, IDbService dbService)
        {
            _mapper = mapper;
            _dbService = dbService;
        }

        public async Task<int> Add(Database.Models.Entity entity)
        {
            PostgresDataAccess.BuildQuery(entity, out string tableName, out string columns, out string parameters);
            PostgresDataAccess.BuildParams(entity, out DynamicParameters parametersModel);
            var result = await _dbService.SetData($"INSERT INTO {tableName} ({columns}) VALUES ({parameters});", parametersModel);

            return result;
        }

        public async Task<bool> Delete(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("id", id);
            PostgresDataAccess.BuildDeleteQueryParams(new Database.Models.Entity { Id = id }, out string columns);
            var count = await _dbService.ExecuteFunctionAsync(Queries.Delete(columns), param);
            return count > 0;
        }

        public async Task<Database.Models.Entity> Get(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("id", id);
            PostgresDataAccess.BuildQuery<Database.Models.Entity>(out string tableName, out string columns);
            var entity = await _dbService.ExecuteQueryAsync<Database.Models.Entity>(Queries.Get(columns), param);

            return entity.FirstOrDefault();
        }

        public async Task<bool> Update(Database.Models.Entity entity)
        {
            var param = new DynamicParameters();
            param.Add("id", entity.Id);

            PostgresDataAccess.BuildUpdateQuery(entity, out string tableName, out string columns);

            var result = await _dbService.SetData($"UPDATE {tableName} SET {columns} WHERE id = @id;", entity);

            return result > 0;
        }
    }
}
