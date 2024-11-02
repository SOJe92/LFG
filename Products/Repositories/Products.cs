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
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Database.Models.Products>> GetAsync(Guid id)
        {
            var param = new DynamicParameters();
            param.Add("puserid", id);
            PostgresDataAccess.BuildQuery<Database.Models.Products>(out _, out string columns);
            var entities = await _dbService.ExecuteQueryAsync<Database.Models.Products>(Queries.GetByUserId(columns), param);
            return entities;
        }
    }
}
