using Dapper;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;
using SearchAndRescue.Products.Database;
using IProductsRepo = SearchAndRescue.Products.Contracts.Repositories.IProducts;

namespace SearchAndRescue.Products.Repositories
{
    public class Products : IProductsRepo
    {
        private readonly IDbService _dbService;
        public Products(IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<IEnumerable<Database.Models.Products>> GetAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.Products(), out string tableName, out string columns, out DynamicParameters parameters);
            var products = await _dbService.ExecuteQueryAsync<Database.Models.Products>(Core.Database.Queries.Get(columns, tableName), parameters);

            return products;
        }

        public async Task<IEnumerable<Database.Models.Products>> GetAsync(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("puserid", id);
            var products = await _dbService.ExecuteQueryAsync<Database.Models.Products>(Queries.GetByUserId, param);
            return products;
        }
    }
}
