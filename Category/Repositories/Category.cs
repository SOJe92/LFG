using Dapper;
using SearchAndRescue.Category.Contracts.Repositories;
using SearchAndRescue.Core.Database.Contracts;
using SearchAndRescue.Helpers;

namespace SearchAndRescue.Category.Repositories
{
    public class Category : ICategory
    {
        private readonly IDbService _dbService;
        public Category(IDbService dbService) => _dbService = dbService;

        public async Task<IEnumerable<Database.Models.Category>> GetCategoriesAsync()
        {
            PostgresDataAccess.BuildGetQuery(new Database.Models.Category(), out string tableName, out string columns, out DynamicParameters parameters);
            var categories = await _dbService.ExecuteQueryAsync<Database.Models.Category>(Core.Database.Queries.Get(columns, tableName), parameters);

            return categories;
        }

        public async Task<Database.Models.Category> GetCategoryAsync(Database.Models.Category category)
        {
            PostgresDataAccess.BuildGetQuery(category, out string tableName, out string columns, out DynamicParameters parameters, "id");
            category = await _dbService.ExecuteQueryFirstAsync<Database.Models.Category>(Core.Database.Queries.Get(columns, tableName), parameters);

            return category;
        }
    }
}
