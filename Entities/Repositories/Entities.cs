using AutoMapper;
using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Entities.Contracts.Repositories;
using SearchAndRescue.Entities.Database;
using SearchAndRescue.Helpers;
using System.Data;

namespace SearchAndRescue.Entities.Repositories
{
    public class Entities : IEntities
    {
        private readonly IMapper _mapper;
        private readonly IDbService _dbService;

        public Entities(IMapper mapper, IDbService dbService)
        {
            _mapper = mapper;
            _dbService = dbService;
        }

        public async Task<int> Add(Dtos.Post.Entity entity)
        {
            Models.Entity model = _mapper.Map<Models.Entity>(entity);
            PostgresDataAccess.BuildQuery(model, out string tableName, out string columns, out string parameters);

            var result = await _dbService.SetData($"INSERT INTO {tableName} ({columns}) VALUES ({parameters});", model);

            return result;
        }

        public async Task<int> Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<Models.Entity> Get(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("id", id);
            PostgresDataAccess.BuildQuery<Models.Entity>(out string tableName, out string columns);
            var entity = await _dbService.ExecuteFunctionAsync<Models.Entity>(Queries.Get(columns), param);

            return entity.FirstOrDefault();
        }

        public async Task<IEnumerable<Models.Entity>> GetAll(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("puserid", id);
            PostgresDataAccess.BuildQuery<Models.Entity>(out _, out string columns);
            var entities = await _dbService.ExecuteFunctionAsync<Models.Entity>(Queries.GetAll(columns), param);
            return entities;
        }

        public async Task<int> Update(Dtos.Put.Entity entity)
        {
            var param = new DynamicParameters();
            param.Add("id", entity.Id);

            Models.Entity model = _mapper.Map<Models.Entity>(entity);
            PostgresDataAccess.BuildUpdateQuery(model, out string tableName, out string columns);

            var result = await _dbService.SetData($"UPDATE {tableName} SET {columns} WHERE id = @id;", entity);

            return result;
        }
    }
}
