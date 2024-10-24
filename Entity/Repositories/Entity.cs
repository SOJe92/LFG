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

        public async Task<int> Add(Dtos.Post.Entity entity)
        {
            Models.Entity model = _mapper.Map<Models.Entity>(entity);
            PostgresDataAccess.BuildQuery(model, out string tableName, out string columns, out string parameters);
            PostgresDataAccess.BuildParams(model, out DynamicParameters parametersModel);
            var result = await _dbService.SetData($"INSERT INTO {tableName} ({columns}) VALUES ({parameters});", parametersModel);

            return result;
        }

        public async Task<bool> Delete(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("id", id);
            PostgresDataAccess.BuildDeleteQueryParams(new Models.Entity { Id = id }, out string columns);
            var count = await _dbService.ExecuteFunctionAsync(Queries.Delete(columns), param);
            return count > 0;
        }

        public async Task<Models.Entity> Get(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("id", id);
            PostgresDataAccess.BuildQuery<Models.Entity>(out string tableName, out string columns);
            var entity = await _dbService.ExecuteQueryAsync<Models.Entity>(Queries.Get(columns), param);

            return entity.FirstOrDefault();
        }

        public async Task<bool> Update(Dtos.Put.Entity entity)
        {
            var param = new DynamicParameters();
            param.Add("id", entity.Id);

            Models.Entity model = _mapper.Map<Models.Entity>(entity);
            PostgresDataAccess.BuildUpdateQuery(model, out string tableName, out string columns);

            var result = await _dbService.SetData($"UPDATE {tableName} SET {columns} WHERE id = @id;", model);

            return result > 0;
        }
    }
}
