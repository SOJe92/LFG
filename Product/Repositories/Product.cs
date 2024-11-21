using AutoMapper;
using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Product.Contracts.Repositories;
using SearchAndRescue.Product.Database;
using SearchAndRescue.Helpers;
using System.Data;

namespace SearchAndRescue.Product.Repositories
{
    public class Product : IProduct
    {
        private readonly IMapper _mapper;
        private readonly IDbService _dbService;

        public Product(IMapper mapper, IDbService dbService)
        {
            _mapper = mapper;
            _dbService = dbService;
        }

        public async Task<int> Add(Database.Models.Product product)
        {
            PostgresDataAccess.BuildQuery(product, out string tableName, out string columns, out string parameters);
            PostgresDataAccess.BuildParams(product, out DynamicParameters parametersModel);
            var result = await _dbService.SetData($"INSERT INTO {tableName} ({columns}) VALUES ({parameters});", parametersModel);

            return result;
        }

        public async Task<bool> Delete(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("id", id);
            PostgresDataAccess.BuildDeleteQuery(new Database.Models.Product { Id = id }, out string columns);
            var count = await _dbService.ExecuteFunctionAsync(Queries.Delete(columns), param);
            return count > 0;
        }

        public async Task<Database.Models.Product> Get(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("id", id);
            PostgresDataAccess.BuildQuery<Database.Models.Product>(out string tableName, out string columns);
            var product = await _dbService.ExecuteQueryAsync<Database.Models.Product>(Queries.Get(columns), param);

            return product.FirstOrDefault();
        }

        public async Task<bool> Update(Database.Models.Product product)
        {
            var param = new DynamicParameters();
            param.Add("id", product.Id);

            PostgresDataAccess.BuildUpdateQuery(product, out string tableName, out string columns, out DynamicParameters parameters);

            var result = await _dbService.SetData< bool>($"UPDATE {tableName} SET {columns} WHERE id = @id;", parameters);

            return result ;
        }
    }
}
